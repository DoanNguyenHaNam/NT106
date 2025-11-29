using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        const string ConnStr = @"Server=(localdb)\MSSQLLocalDB;Database=AuthDB;Integrated Security=True;";

        static byte[] Sha256(string s)
        {
            using var sha = SHA256.Create();
            return sha.ComputeHash(Encoding.UTF8.GetBytes(s));
        }
        public Form1()
        {
            InitializeComponent();
            btn_login.Click += btn_login_Click;
            tb_password.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            var u = tb_username.Text.Trim();
            var p = tb_password.Text;

            if (string.IsNullOrWhiteSpace(u) || string.IsNullOrEmpty(p))
            { MessageBox.Show("Nhập đủ tên đăng nhập và mật khẩu."); return; }

            try
            {
                using var conn = new SqlConnection(ConnStr);
                await conn.OpenAsync();

                using var cmd = new SqlCommand(
                    "SELECT 1 FROM Users WHERE Username=@u AND PasswordHash=@p", conn);
                cmd.Parameters.AddWithValue("@u", u);
                cmd.Parameters.Add("@p", System.Data.SqlDbType.VarBinary, 32).Value = Sha256(p);

                using var r = await cmd.ExecuteReaderAsync();
                MessageBox.Show(await r.ReadAsync() ? "Đăng nhập OK" : "Sai tài khoản/mật khẩu");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            signUp signUpForm = new signUp();
            signUpForm.Show();
            this.Hide();
        }
    }
}
