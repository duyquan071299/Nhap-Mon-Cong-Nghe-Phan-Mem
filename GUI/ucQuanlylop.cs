using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTHDTO;
using QLTHBUS;

namespace GUI
{
    public partial class ucQuanlylop : UserControl
    {
        public ucQuanlylop()
        {
            InitializeComponent();
        }

        private QuanLyLopBUS quanlylop;
        private QuanLyHocSinhBUS quanlyhocsinh;
        private void ucQuanlylop_Load(object sender, EventArgs e)
        {
            quanlylop = new QuanLyLopBUS();
            quanlyhocsinh = new QuanLyHocSinhBUS();
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
                tbTenLop.Text = e.Node.Text;
            }
        }

        private void LapDanhSach_Click(object sender, EventArgs e)
        {
            List<QuanLyHocSinhDTO> danhsachhocsinh = new List<QuanLyHocSinhDTO>();
            danhsachhocsinh = quanlyhocsinh.SelectAll();
            string malop;
            switch (tbTenLop.Text)
            {
                case "10A1":
                    malop = "001";
                    break;
                case "10A2":
                    malop = "002";
                    break;
                case "10A3":
                    malop = "003";
                    break;
                case "10A4":
                    malop = "004";
                    break;
                case "11A1":
                    malop = "005";
                    break;
                case "11A2":
                    malop = "006";
                    break;
                case "11A3":
                    malop = "007";
                    break;
                case "12A1":
                    malop = "008";
                    break;
                case "12A2":
                    malop = "009";
                    break;
                default:
                    malop = "";
                    break;
            }

        }
    }
}
