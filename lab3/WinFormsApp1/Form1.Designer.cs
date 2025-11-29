namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tb_username = new TextBox();
            tb_password = new TextBox();
            label4 = new Label();
            btn_login = new Button();
            btn_signup = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(252, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 45);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(168, 114);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(168, 162);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu";
            label3.Click += label2_Click;
            // 
            // tb_username
            // 
            tb_username.Font = new Font("Segoe UI", 15F);
            tb_username.Location = new Point(359, 111);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(219, 34);
            tb_username.TabIndex = 2;
            tb_username.TextChanged += tb_username_TextChanged;
            // 
            // tb_password
            // 
            tb_password.Font = new Font("Segoe UI", 15F);
            tb_password.Location = new Point(359, 159);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(219, 34);
            tb_password.TabIndex = 2;
            tb_password.TextChanged += tb_password_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(433, 214);
            label4.Name = "label4";
            label4.Size = new Size(0, 28);
            label4.TabIndex = 3;
            label4.Click += label4_Click;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 15F);
            btn_login.Location = new Point(273, 233);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(160, 43);
            btn_login.TabIndex = 5;
            btn_login.Text = "Đăng nhập";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_signup
            // 
            btn_signup.Font = new Font("Segoe UI", 15F);
            btn_signup.Location = new Point(273, 300);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(160, 43);
            btn_signup.TabIndex = 5;
            btn_signup.Text = "Đăng kí";
            btn_signup.UseVisualStyleBackColor = true;
            btn_signup.Click += btn_signup_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_signup);
            Controls.Add(btn_login);
            Controls.Add(label4);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_username;
        private TextBox tb_password;
        private Label label4;
        private Button btn_login;
        private Button btn_signup;
    }
}
