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
    public partial class ucTracuuDiem : UserControl
    {
        public ucTracuuDiem()
        {
            InitializeComponent();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            TraCuuDiemDTO ttd = new TraCuuDiemDTO();
            ttd.MSHocSInh = tbMaHs.Text;
            ttd.HoTenHS = tbTen.Text;
            ttd.Mon = cbMon.Text;
            ttd.HocKy = cbHK.Text;
            List<TraCuuDiemDTO> DanhSachDiem = tracuu.TraCuuDiem(ttd);
            if (DanhSachDiem == null)
            {
                MessageBox.Show("Có lỗi khi lấy thông tin điểm của học sinh");
                return;
            }
            dtgvDSDiem.DataSource = null;

            dtgvDSDiem.AutoGenerateColumns = false;
            dtgvDSDiem.AllowUserToAddRows = false;
            dtgvDSDiem.DataSource = DanhSachDiem;


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvDSDiem.DataSource];
            myCurrencyManager.Refresh();
        }
        private QuanLyDiemBUS quanlydiem;
        private TraCuuBUS tracuu;
        private void ucTracuuDiem_Load(object sender, EventArgs e)
        {
            tracuu = new TraCuuBUS();
            quanlydiem = new QuanLyDiemBUS();
            List<QuanLyDiemDTO> danhsachmon = quanlydiem.SelectMon();

            foreach (var temp in danhsachmon)
            {
                cbMon.Items.Add(temp.Mon);
            }
        }
    }
}
