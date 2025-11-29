import socket, threading, base64, hashlib, os

try:
    import pyodbc
except:
    os.system("pip install pyodbc")
    import pyodbc

HOST, PORT = "0.0.0.0", 11000
DELIM = "<EOF>"

CONN_STR = (
    "Driver={ODBC Driver 18 for SQL Server};"
    "Server=(localdb)\\MSSQLLocalDB;"
    "Database=AuthDB;"
    "Trusted_Connection=yes;"
    "Encrypt=yes;TrustServerCertificate=yes;"
)

def get_db():
    return pyodbc.connect(CONN_STR)

def login_hashed(username: str, pwd_hash_bytes: bytes) -> bool:
    with get_db() as conn:
        cur = conn.cursor()
        cur.execute(
            "SELECT COUNT(1) FROM dbo.Users WHERE Username=? AND PasswordHash=?",
            (username, pwd_hash_bytes),
        )
        return bool(cur.fetchone()[0] == 1)

def signup_hashed(username: str, pwd_hash_bytes: bytes, phone: str) -> tuple[bool, str]:
    # if not (username and pwd_hash_bytes and phone):
    #     return False, "Thiếu username/password/phone"
    with get_db() as conn:
        cur = conn.cursor()
        cur.execute("SELECT COUNT(1) FROM dbo.Users WHERE Username=?", (username,))
        if cur.fetchone()[0] > 0:
            return False, "Username đã tồn tại"

        cur.execute(
            "INSERT INTO dbo.Users (Username, PasswordHash, Phone, CreatedAt) "
            "VALUES (?, ?, ?, SYSUTCDATETIME())",
            (username, pwd_hash_bytes, phone),
        )
        conn.commit()
        return True, "Signup success"

def handle_client(sock: socket.socket, addr):
    try:
        buf = ""
        while True:
            data = sock.recv(4096)
            if not data:
                break
            buf += data.decode("utf-8", errors="replace")

            while DELIM in buf:
                msg, buf = buf.split(DELIM, 1)
                msg = msg.strip()
                if not msg:
                    sock.sendall(f"ERR: empty message{DELIM}".encode()); continue

                parts = msg.split("|")
                try:
                    cmd = parts[0].upper()
                    if cmd == "LOGIN" and len(parts) >= 3:
                        username = parts[1]
                        pwd_hash = base64.b64decode(parts[2])
                        ok = login_hashed(username, pwd_hash)
                        sock.sendall((f"OK{DELIM}" if ok else f"ERR: wrong user/pass{DELIM}").encode())
                    elif cmd == "SIGNUP" and len(parts) >= 4:
                        username = parts[1]
                        pwd_hash = base64.b64decode(parts[2])
                        phone    = parts[3]
                        ok, msg2 = signup_hashed(username, pwd_hash, phone)
                        sock.sendall((f"OK{DELIM}" if ok else f"ERR: {msg2}{DELIM}").encode())
                    else:
                        sock.sendall(f"ERR: bad format{DELIM}".encode())
                except Exception as e:
                    sock.sendall(f"ERR: {e}{DELIM}".encode())
    finally:
        sock.close()

def main():
    with get_db() as _:
        pass
    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    s.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
    s.bind((HOST, PORT))
    s.listen(50)
    print(f"[SERVER] {HOST}:{PORT}")
    try:
        while True:
            c, a = s.accept()
            threading.Thread(target=handle_client, args=(c, a), daemon=True).start()
    finally:
        s.close()

if __name__ == "__main__":
    main()
