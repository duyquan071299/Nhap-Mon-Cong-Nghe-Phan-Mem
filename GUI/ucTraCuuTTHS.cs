using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTHBUS;
using QLTHDTO;
namespace GUI
{
    public partial class ucTraCuuTTHS : UserControl
    {
        public ucTraCuuTTHS()
        {
            InitializeComponent();
        }

        private TraCuuBUS tthocsinh;
        private QuanLyLopBUS quanlylop;
        
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            TraCuuTTHSDTO tths = new TraCuuTTHSDTO();
            tths.HoTen = tbTen.Text;
            tths.MaHS = tbMaHS.Text;
            tths.Lop = cbLop.Text;
            List<TraCuuTTHSDTO> DanhSachHocSinh = tthocsinh.TraCuuTTHS(tths);
            if (DanhSachHocSinh == null)
            {
                MessageBox.Show("Có lỗi khi lấy thông tin học sinh");
                return;
            }
            dtgvDanhSachSinhVien.DataSource = null;

            dtgvDanhSachSinhVien.AutoGenerateColumns = false;
            dtgvDanhSachSinhVien.AllowUserToAddRows = false;
            dtgvDanhSachSinhVien.DataSource = DanhSachHocSinh;


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvDanhSachSinhVien.DataSource];
            myCurrencyManager.Refresh();
        }
        

        private void ucTraCuuTTHS_Load(object sender, EventArgs e)
        {
            quanlylop = new QuanLyLopBUS();
            tthocsinh = new TraCuuBUS();
            List<string> tenlop = new List<string>();

            tenlop = quanlylop.SelectLop("K10");
            foreach (string temp in tenlop)
            {
                cbLop.Items.Add(temp);
            }
            tenlop = quanlylop.SelectLop("K11");
            foreach (string temp in tenlop)
            {
                cbLop.Items.Add(temp);
            }
            tenlop = quanlylop.SelectLop("K12");
            foreach (string temp in tenlop)
            {
                cbLop.Items.Add(temp);
            }
        }
    }
}
