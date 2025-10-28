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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            lb_name.Text = "Welcome, " + Opening.username;
            rtb.AppendText("Xin chao "  + Opening.username 
                                        + "!\n\tChúc bạn ngày mới tốt lành\n"
                                        + "Bây giờ là: " + DateTime.Now + "\n");
        }
    }
}
