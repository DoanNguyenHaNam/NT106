using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Ex3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(btn_username.Text) || string.IsNullOrWhiteSpace(btn_password.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            string pwdHashBase64 = Convert.ToBase64String(Opening.Sha256Bytes(btn_password.Text));
            string message = $"LOGIN|{btn_username.Text}|{pwdHashBase64}";
            string response = Socket.Send(message);
            //MessageBox.Show("Server trả về: " + response);
            if (response == "OK")
            {
                Opening.username = btn_username.Text;
                dashboard Dbform = new dashboard();
                Dbform.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}
