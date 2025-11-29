namespace Ex3
{
    partial class SignUp
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
            label4 = new Label();
            button1 = new Button();
            label3 = new Label();
            btn_password = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btn_username = new TextBox();
            label5 = new Label();
            btn_repassword = new TextBox();
            label6 = new Label();
            btn_sdt = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(592, 455);
            label4.Name = "label4";
            label4.Size = new Size(157, 28);
            label4.TabIndex = 13;
            label4.Text = "Đã có tài khoản?";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(314, 430);
            button1.Name = "button1";
            button1.Size = new Size(195, 53);
            button1.TabIndex = 12;
            button1.Text = "Đăng kí";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 227);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 11;
            label3.Text = "Mật khẩu";
            // 
            // btn_password
            // 
            btn_password.Location = new Point(314, 224);
            btn_password.Margin = new Padding(5, 6, 5, 6);
            btn_password.Name = "btn_password";
            btn_password.PasswordChar = '*';
            btn_password.Size = new Size(437, 34);
            btn_password.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 170);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 9;
            label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(385, 63);
            label1.Name = "label1";
            label1.Size = new Size(87, 28);
            label1.TabIndex = 8;
            label1.Text = "SIGN UP";
            // 
            // btn_username
            // 
            btn_username.Location = new Point(312, 167);
            btn_username.Margin = new Padding(5, 6, 5, 6);
            btn_username.Name = "btn_username";
            btn_username.Size = new Size(437, 34);
            btn_username.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(123, 295);
            label5.Name = "label5";
            label5.Size = new Size(171, 28);
            label5.TabIndex = 15;
            label5.Text = "Nhập lại mật khẩu";
            label5.Click += label5_Click;
            // 
            // btn_repassword
            // 
            btn_repassword.Location = new Point(314, 292);
            btn_repassword.Margin = new Padding(5, 6, 5, 6);
            btn_repassword.Name = "btn_repassword";
            btn_repassword.PasswordChar = '*';
            btn_repassword.Size = new Size(437, 34);
            btn_repassword.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(123, 352);
            label6.Name = "label6";
            label6.Size = new Size(128, 28);
            label6.TabIndex = 17;
            label6.Text = "Số điện thoại";
            // 
            // btn_sdt
            // 
            btn_sdt.Location = new Point(314, 349);
            btn_sdt.Margin = new Padding(5, 6, 5, 6);
            btn_sdt.Name = "btn_sdt";
            btn_sdt.Size = new Size(437, 34);
            btn_sdt.TabIndex = 16;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 637);
            Controls.Add(label6);
            Controls.Add(btn_sdt);
            Controls.Add(label5);
            Controls.Add(btn_repassword);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(btn_password);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_username);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "SignUp";
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button button1;
        private Label label3;
        private TextBox btn_password;
        private Label label2;
        private Label label1;
        private TextBox btn_username;
        private Label label5;
        private TextBox btn_repassword;
        private Label label6;
        private TextBox btn_sdt;
    }
}