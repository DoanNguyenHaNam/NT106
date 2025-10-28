using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(btn_username.Text) || string.IsNullOrWhiteSpace(btn_password.Text) || string.IsNullOrWhiteSpace(btn_sdt.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            foreach (char c in btn_username.Text)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    MessageBox.Show("Tên đăng nhập chỉ được chứa chữ cái và chữ số.");
                    return;
                }
            }
            if (btn_password.Text != btn_repassword.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.");
                return;
            }
            if (btn_password.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.");
                return;
            }
            if (btn_sdt.Text.Length != 10 || !btn_sdt.Text.All(char.IsDigit) || btn_sdt.Text[0] != '0')
            {
                MessageBox.Show("Số điện thoại không hợp lệ.");
                return;
            }
            string pwdHashBase64 = Convert.ToBase64String(Opening.Sha256Bytes(btn_password.Text));
            string message = $"SIGNUP|{btn_username.Text}|{pwdHashBase64}|{btn_sdt.Text}"; 
            string response = Socket.Send(message);

            if (response == "OK")
            {
                MessageBox.Show("Đăng ký thành công!");
                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại: " + response);
            }
        }
    }
}
