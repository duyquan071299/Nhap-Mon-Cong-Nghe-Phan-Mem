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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;
        }

        

        

        private void Sidemenu_Click(object sender, EventArgs e)
        {
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
            quanly1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;
            mnuQuanly mnuQuanly = new mnuQuanly();
            mnuQuanly.Show();
            quanLyLop1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button2.Height;
            sidepanel.Top = button2.Top;
            mnuTracuu mnuTracuu = new mnuTracuu();
            mnuTracuu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button3.Height;
            sidepanel.Top = button3.Top;
            mnuBaocao mnuBaocao = new mnuBaocao();
            mnuBaocao.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button4.Height;
            sidepanel.Top = button4.Top;
            mnuHethong mnuHethong = new mnuHethong();
            mnuHethong.Show();
        }
    }
}
