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
    public partial class ucBaocaoMon : UserControl
    {
        public ucBaocaoMon()
        {
            InitializeComponent();
        }

        private ucThamso a = new ucThamso();
        private BaoCaoBUS BaoCaoBUS;
        private QuanLyDiemBUS quanlydiem;
        private QuanLyLopBUS quanlylop;
        private void ucBaocaoMon_Load(object sender, EventArgs e)
        {
            BaoCaoBUS = new BaoCaoBUS();
            quanlydiem = new QuanLyDiemBUS();
            List<QuanLyDiemDTO> danhsachmon = quanlydiem.SelectMon();

            foreach (var temp in danhsachmon)
            {
                cbMon.Items.Add(temp.Mon);
            }
        }

        private void btnLapBC_Click(object sender, EventArgs e)
        {
            
            a.Load_DanhSachThamSo();
            string DiemDat = string.Empty;
            foreach (DataGridViewRow temp in a.dtgvThamSo.Rows)
            {
                if (temp.Cells[0].Value.ToString() == "Điểm đạt môn")
                {
                    DiemDat = temp.Cells[1].Value.ToString();
                }
            }
            BaoCaoMonDTO BCMDTO = new BaoCaoMonDTO();
            BCMDTO.Mon = cbMon.Text;
            BCMDTO.HocKy = cbHK.Text;
            BCMDTO.DiemDat = DiemDat;
            List<BaoCaoMonDTO> DanhSachBaoCao = BaoCaoBUS.TaoBaoCaoMon(BCMDTO);
            if (DanhSachBaoCao == null)
            {
                MessageBox.Show("Có lỗi khi lấy thông tin ");
                return;
            }
            dtgvBaoCaoMon.DataSource = null;

            dtgvBaoCaoMon.AutoGenerateColumns = false;
            dtgvBaoCaoMon.AllowUserToAddRows = false;
            dtgvBaoCaoMon.DataSource = DanhSachBaoCao;


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvBaoCaoMon.DataSource];
            myCurrencyManager.Refresh();

        }
    }
}
