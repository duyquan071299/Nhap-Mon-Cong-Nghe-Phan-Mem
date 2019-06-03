using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;

namespace GUI
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            sidepanel.Height = btnQuanLy.Height;
            sidepanel.Top = btnQuanLy.Top;
        }

       
        private void Sidemenu_Click(object sender, EventArgs e)
        {
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnQuanLy.Height;
            sidepanel.Top = btnQuanLy.Top;
            ucQuanLyHocSinh ucQuanLyHocSinh = new ucQuanLyHocSinh();
            pnManHinhXuLy.Controls.Clear();
            pnManHinhXuLy.Controls.Add(ucQuanLyHocSinh);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button2.Height;
            sidepanel.Top = button2.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button3.Height;
            sidepanel.Top = button3.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button4.Height;
            sidepanel.Top = button4.Top;
        }
    }
}
