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
    public partial class mnuTracuu : Form
    {
        public mnuTracuu()
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
            ucTraCuuTTHS guiTraCuuTTHS = new ucTraCuuTTHS();
            (this.Owner as frmMenu).pnManHinhXuLy.Controls.Add(guiTraCuuTTHS);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (this.Owner as frmMenu).pnManHinhXuLy.Controls.Clear();
            ucTracuuDiem guiTraCuuDiem = new ucTracuuDiem();
            (this.Owner as frmMenu).pnManHinhXuLy.Controls.Add(guiTraCuuDiem);
            this.Close();
        }
    }
}
