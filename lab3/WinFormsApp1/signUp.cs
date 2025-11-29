using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public partial class signUp : Form
    {
        const string ConnStr = @"Server=(localdb)\MSSQLLocalDB;Database=AuthDB;Integrated Security=True;";

        static byte[] Sha256(string s)
        {
            using var sha = SHA256.Create();
            return sha.ComputeHash(Encoding.UTF8.GetBytes(s));
        }
        public signUp()
        {
            InitializeComponent();
            btn_signup.Click += btn_signup_Click;
            tb_password.UseSystemPasswordChar = true;
            tb_repassword.UseSystemPasswordChar = true;
        }

        private void signUp_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private async void btn_signup_Click(object sender, EventArgs e)
        {
            var u = tb_username.Text.Trim();
            var p1 = tb_password.Text;
            var p2 = tb_repassword.Text;
            var ph = tb_phone.Text.Trim();
            var em = tb_mail.Text.Trim();

            if (string.IsNullOrWhiteSpace(u) || string.IsNullOrEmpty(p1) || string.IsNullOrEmpty(p2))
            { MessageBox.Show("Nhập đủ các ô bắt buộc."); return; }

            if (p1 != p2) { MessageBox.Show("Mật khẩu không khớp."); return; }

            try
            {
                using var conn = new SqlConnection(ConnStr);
                await conn.OpenAsync();

                using var cmd = new SqlCommand(
                    "INSERT INTO Users(Username,PasswordHash,Phone,Email) VALUES(@u,@p,@ph,@em)", conn);
                cmd.Parameters.AddWithValue("@u", u);
                cmd.Parameters.Add("@p", System.Data.SqlDbType.VarBinary, 32).Value = Sha256(p1);
                cmd.Parameters.AddWithValue("@ph", string.IsNullOrWhiteSpace(ph) ? (object)DBNull.Value : ph);
                cmd.Parameters.AddWithValue("@em", string.IsNullOrWhiteSpace(em) ? (object)DBNull.Value : em);

                await cmd.ExecuteNonQueryAsync();
                MessageBox.Show("Đăng ký thành công!");
                this.Close();
            }
            catch (SqlException ex) when (ex.Number == 2627) { MessageBox.Show("Tên đăng nhập đã tồn tại."); }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }
    }
}
