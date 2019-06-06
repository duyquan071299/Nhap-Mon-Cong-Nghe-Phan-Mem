using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class mnuQuanly : Form
    {
        public mnuQuanly()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (this.Owner as frmMenu).pnManHinhXuLy.Controls.Clear();
            ucQuanLyHocSinh guiQuanLyHocSinh = new ucQuanLyHocSinh();
            (this.Owner as frmMenu).pnManHinhXuLy.Controls.Add(guiQuanLyHocSinh);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (this.Owner as frmMenu).pnManHinhXuLy.Controls.Clear();
            ucQuanlylop guiQuanLyLop = new ucQuanlylop();
            (this.Owner as frmMenu).pnManHinhXuLy.Controls.Add(guiQuanLyLop);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (this.Owner as frmMenu).pnManHinhXuLy.Controls.Clear();
            ucQuanlyDiem guiQuanLyDiem = new ucQuanlyDiem();
            (this.Owner as frmMenu).pnManHinhXuLy.Controls.Add(guiQuanLyDiem);
            this.Close();
        }
    }
}
