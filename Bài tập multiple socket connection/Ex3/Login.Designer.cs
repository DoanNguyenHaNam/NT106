namespace Ex3
{
    partial class Login
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
            btn_username = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_password = new TextBox();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // btn_username
            // 
            btn_username.Location = new Point(289, 242);
            btn_username.Margin = new Padding(5, 6, 5, 6);
            btn_username.Name = "btn_username";
            btn_username.Size = new Size(437, 34);
            btn_username.TabIndex = 0;
            btn_username.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(394, 138);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 245);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 2;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 302);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu";
            // 
            // btn_password
            // 
            btn_password.Location = new Point(291, 299);
            btn_password.Margin = new Padding(5, 6, 5, 6);
            btn_password.Name = "btn_password";
            btn_password.PasswordChar = '*';
            btn_password.Size = new Size(437, 34);
            btn_password.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(322, 367);
            button1.Name = "button1";
            button1.Size = new Size(195, 53);
            button1.TabIndex = 5;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(596, 448);
            label4.Name = "label4";
            label4.Size = new Size(130, 28);
            label4.TabIndex = 6;
            label4.Text = "Tạo tài khoản";
            label4.Click += label4_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 633);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(btn_password);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_username);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox btn_username;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox btn_password;
        private Button button1;
        private Label label4;
    }
}