# NT106
---------------------
#Lab3
MSSV: 24521100 - Đoàn Nguyễn Hà Nam

1. Yêu cầu
  - SQL Server LocalDB ( (localdb)\MSSQLLocalDB)
  - Microsoft.Data.SqlClient
2. Chuẩn bị
  - Lệnh cmd:
      + sqllocaldb info
      + sqllocaldb start MSSQLLocalDB
3. Tạo CSDL & bảng
  - Tạo database AuthDB hoặc sử dụng SQLQuery2.sql
4. Phương thức kết nối
  - Sử dụng: const string ConnStr = @"Server=(localdb)\MSSQLLocalDB;Database=AuthDB;Integrated Security=True;";
5. UI Form
  - Đăng nhập:
    <br><img width="672" height="401" alt="image" src="https://github.com/user-attachments/assets/6d531fcc-14e6-417d-9f94-a0e533c13aac" />
  - Đăng kí:
    <br><img width="637" height="429" alt="image" src="https://github.com/user-attachments/assets/3d41a6f5-894b-431b-9c8f-170d3127e277" />

---------------------
