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
    public partial class mnuBaocao : Form
    {
        public mnuBaocao()
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
            ucBaocaoMon guiBaoCaoMon = new ucBaocaoMon();
            (this.Owner as frmMenu).pnManHinhXuLy.Controls.Add(guiBaoCaoMon);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (this.Owner as frmMenu).pnManHinhXuLy.Controls.Clear();
            ucBaocaoHocki guiBaoCaoNam = new ucBaocaoHocki();
            (this.Owner as frmMenu).pnManHinhXuLy.Controls.Add(guiBaoCaoNam);
            this.Close();
        }
    }
}
