using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTHBUS;
using QLTHDTO;
namespace GUI
{
    public partial class DanhSachHocSinh : Form
    {
        public DanhSachHocSinh()
        {
            InitializeComponent();
        }
        private QuanLyHocSinhBUS qlhsBus;
        private void DanhSachHocSinh_Load(object sender, EventArgs e)
        {
            qlhsBus = new QuanLyHocSinhBUS();
            LoadDanhSachHS();
        }
        public void LoadDanhSachHS()
        {
            List<QuanLyHocSinhDTO> DanhSachHocSinh = qlhsBus.SelectHSChuaCoLoP();
            if (DanhSachHocSinh == null)
            {
                MessageBox.Show("Có lỗi khi lấy Món ăn từ DB");
                return;
            }
            dtgvDanhSachHS.DataSource = null;

            dtgvDanhSachHS.AutoGenerateColumns = false;
            dtgvDanhSachHS.AllowUserToAddRows = false;
            dtgvDanhSachHS.DataSource = DanhSachHocSinh;


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvDanhSachHS.DataSource];
            myCurrencyManager.Refresh();
        }
    }
}
