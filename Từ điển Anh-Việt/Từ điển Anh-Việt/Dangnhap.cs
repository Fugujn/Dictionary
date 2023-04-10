using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Từ_điển_Anh_Việt
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void btDangnhap_Click(object sender, EventArgs e)
        {
            if (txtDangnhap.Text == "" || txtMatkhau .Text!= "admin")
                Application.Exit();
            Form1.UserName = txtDangnhap.Text;
            Close();

        }

        private void btDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Form1.UserName == "")
                Application.Exit();
        }
    }
}
