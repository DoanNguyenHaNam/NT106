namespace WinFormsApp1
{
    partial class signUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_signup = new Button();
            btn_login = new Button();
            linkLabel1 = new LinkLabel();
            tb_password = new TextBox();
            tb_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            tb_repassword = new TextBox();
            tb_phone = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tb_mail = new TextBox();
            SuspendLayout();
            // 
            // btn_signup
            // 
            btn_signup.Font = new Font("Segoe UI", 15F);
            btn_signup.Location = new Point(283, 346);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(160, 43);
            btn_signup.TabIndex = 12;
            btn_signup.Text = "Đăng kí";
            btn_signup.UseVisualStyleBackColor = true;
            btn_signup.Click += btn_signup_Click;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 15F);
            btn_login.Location = new Point(283, 395);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(160, 43);
            btn_login.TabIndex = 13;
            btn_login.Text = "Đăng nhập";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 15F);
            linkLabel1.ForeColor = Color.Red;
            linkLabel1.Location = new Point(460, 361);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 28);
            linkLabel1.TabIndex = 11;
            // 
            // tb_password
            // 
            tb_password.Font = new Font("Segoe UI", 15F);
            tb_password.Location = new Point(386, 148);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(219, 34);
            tb_password.TabIndex = 9;
            // 
            // tb_username
            // 
            tb_username.Font = new Font("Segoe UI", 15F);
            tb_username.Location = new Point(386, 100);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(219, 34);
            tb_username.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(195, 151);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 7;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(195, 103);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 8;
            label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(314, 31);
            label1.Name = "label1";
            label1.Size = new Size(146, 45);
            label1.TabIndex = 6;
            label1.Text = "ĐĂNG KÍ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(195, 202);
            label4.Name = "label4";
            label4.Size = new Size(171, 28);
            label4.TabIndex = 7;
            label4.Text = "Nhập lại mật khẩu";
            // 
            // tb_repassword
            // 
            tb_repassword.Font = new Font("Segoe UI", 15F);
            tb_repassword.Location = new Point(386, 199);
            tb_repassword.Name = "tb_repassword";
            tb_repassword.PasswordChar = '*';
            tb_repassword.Size = new Size(219, 34);
            tb_repassword.TabIndex = 9;
            // 
            // tb_phone
            // 
            tb_phone.Font = new Font("Segoe UI", 15F);
            tb_phone.Location = new Point(386, 250);
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(219, 34);
            tb_phone.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(195, 253);
            label5.Name = "label5";
            label5.Size = new Size(128, 28);
            label5.TabIndex = 7;
            label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(195, 298);
            label6.Name = "label6";
            label6.Size = new Size(63, 28);
            label6.TabIndex = 7;
            label6.Text = "Gmail";
            // 
            // tb_mail
            // 
            tb_mail.Font = new Font("Segoe UI", 15F);
            tb_mail.Location = new Point(386, 295);
            tb_mail.Name = "tb_mail";
            tb_mail.Size = new Size(219, 34);
            tb_mail.TabIndex = 9;
            // 
            // signUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_signup);
            Controls.Add(btn_login);
            Controls.Add(linkLabel1);
            Controls.Add(tb_mail);
            Controls.Add(tb_phone);
            Controls.Add(tb_repassword);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "signUp";
            Text = "signUp";
            Load += signUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_signup;
        private Button btn_login;
        private LinkLabel linkLabel1;
        private TextBox tb_password;
        private TextBox tb_username;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox tb_repassword;
        private TextBox tb_phone;
        private Label label5;
        private Label label6;
        private TextBox tb_mail;
    }
}