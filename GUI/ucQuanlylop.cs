using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucQuanlylop : UserControl
    {
        public ucQuanlylop()
        {
            InitializeComponent();
        }

        private void ucQuanlylop_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                this.treeView1.Nodes[0].Nodes.Add("Lớp 10A" + (i+1).ToString());
            }
            for (int i = 0; i < 3; i++)
            {
                this.treeView1.Nodes[1].Nodes.Add("Lớp 11A" + (i+1).ToString());
            }
            for (int i = 0; i < 2; i++)
            {
                this.treeView1.Nodes[2].Nodes.Add("Lớp 12A" + (i+1).ToString());
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent!=null)
            {
                ThongTinLop.Text = e.Node.Text;
            }
        }
    }
}
