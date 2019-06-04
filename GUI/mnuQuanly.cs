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
            ucQuanLyHocSinh ucQuanLyHocSinh = new ucQuanLyHocSinh();
            (this.Owner as frmMenu).pnManHinhXuLy.Controls.Add(ucQuanLyHocSinh);
            this.Close();
        }
    }
}
