namespace Ex3
{
    partial class dashboard
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
            lb_name = new Label();
            rtb = new RichTextBox();
            SuspendLayout();
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Location = new Point(396, 9);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(60, 28);
            lb_name.TabIndex = 0;
            lb_name.Text = "------";
            // 
            // rtb
            // 
            rtb.Location = new Point(12, 51);
            rtb.Name = "rtb";
            rtb.Size = new Size(836, 552);
            rtb.TabIndex = 1;
            rtb.Text = "";
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 615);
            Controls.Add(rtb);
            Controls.Add(lb_name);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "dashboard";
            Text = "dashboard";
            Load += dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_name;
        private RichTextBox rtb;
    }
}