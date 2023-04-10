using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;


    namespace Từ_điển_Anh_Việt
    {
  
        public partial class Form1 : Form
        {
       
        public static string UserName = "";
            public Form1()
            {
                Dangnhap f = new Dangnhap();
                f.ShowDialog();
                 read_file();
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void btSearch_Click(object sender, EventArgs e)
            {

            }
        private void read_file()
        {
            using (StreamReader rd=new StreamReader("TudienA-V.txt"))
            {
                int count;
                

                }
            }
        }
        }   
    }

