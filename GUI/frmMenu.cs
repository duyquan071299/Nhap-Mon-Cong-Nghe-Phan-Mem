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
        private bool check_mnuQuanLy = false; //kiem tra menu quan ly co dang mo hay khong?
        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnQuanLy.Height;
            sidepanel.Top = btnQuanLy.Top;
            if (check_mnuQuanLy == false)
            {
                check_mnuQuanLy = true;
                mnuQuanly menuQL = new mnuQuanly();
                menuQL.Owner = this;
                menuQL.FormClosed += MenuQL_FormClosed;
                menuQL.ShowDialog();
            }
        }

        private void MenuQL_FormClosed(object sender, FormClosedEventArgs e)
        {
            check_mnuQuanLy = false;
        }


        private bool check_mnTraCuu = false;
        private void button2_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button2.Height;
            sidepanel.Top = button2.Top;
            if (check_mnTraCuu == false)
            {
                check_mnTraCuu = true;
                mnuTracuu menuTC = new mnuTracuu();
                menuTC.Owner = this;
                menuTC.FormClosed += MenuTC_FormClosed;
                menuTC.ShowDialog();
            }
        }

        private void MenuTC_FormClosed(object sender, FormClosedEventArgs e)
        {
            check_mnTraCuu = false;
        }

        private bool check_mnBaoCao = false;
        private void button3_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button3.Height;
            sidepanel.Top = button3.Top;
            if (check_mnBaoCao == false)
            {
                check_mnBaoCao = true;
                mnuBaocao menuBC = new mnuBaocao();
                menuBC.Owner = this;
                menuBC.FormClosed += MenuBC_FormClosed;
                menuBC.ShowDialog();
            }
        }

        private void MenuBC_FormClosed(object sender, FormClosedEventArgs e)
        {
            check_mnBaoCao = false;
        }

        private bool check_mnHeThong = false;
        private void button4_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button4.Height;
            sidepanel.Top = button4.Top;
            if (check_mnHeThong == false)
            {
                check_mnHeThong = true;
                mnuHethong menuHT = new mnuHethong();
                menuHT.Owner = this;
                menuHT.FormClosed += MenuHT_FormClosed;
                menuHT.ShowDialog();
            }
        }

        private void MenuHT_FormClosed(object sender, FormClosedEventArgs e)
        {
            check_mnHeThong = false;
        }
    }
}
