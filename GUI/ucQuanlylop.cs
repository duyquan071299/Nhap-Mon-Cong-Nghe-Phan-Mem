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
        
        private int dtgv_hang = -1;
        private ucThamso a = new ucThamso();
        private QuanLyLopBUS quanlylop;
        private QuanLyHocSinhBUS quanlyhocsinh;

        private void ucQuanlylop_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            quanlylop = new QuanLyLopBUS();
            quanlyhocsinh = new QuanLyHocSinhBUS();
            Load_DanhSachHocSinhChuaCoLop();
        }

        private void Load_DanhSachHocSinh(string tenlop)
        {
            List<QuanLyLopDTO> DanhSachHocSinh = quanlylop.SelectDSLop(tenlop);
            if (DanhSachHocSinh == null)
            {
                MessageBox.Show("Có lỗi khi lấy danh sách lớp");
                return;
            }
            dtgvDanhSachLop.DataSource = null;

            dtgvDanhSachLop.AutoGenerateColumns = false;
            dtgvDanhSachLop.AllowUserToAddRows = false;
            dtgvDanhSachLop.DataSource = DanhSachHocSinh;
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvDanhSachLop.DataSource];
            myCurrencyManager.Refresh();
            tbSiSo.Text = dtgvDanhSachLop.RowCount.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            a.Load_DanhSachThamSo();
            List<string> danhsachhocsinhchuacolop = new List<string>();
            foreach(DataGridViewRow temp in dtgvDSHSChuaCoLop.Rows)
            {
                danhsachhocsinhchuacolop.Add(temp.Cells[0].Value.ToString());
            }
            if (danhsachhocsinhchuacolop.Contains(tbMaHS.Text) == false)
            {
                MessageBox.Show("Học sinh không hợp lệ");
                return;
            }
            string sisotoida = string.Empty;
            foreach (DataGridViewRow temp in a.dtgvThamSo.Rows)
            {
                if (temp.Cells[0].Value.ToString() == "Sỉ số lớp tối đa")
                {
                    sisotoida = temp.Cells[1].Value.ToString();
                }
            }
            if (this.dtgvDanhSachLop.RowCount==int.Parse(sisotoida))
            {
                MessageBox.Show("Lớp đã đủ số lượng");
                return;
            }
            List<string> danhsachmshs = new List<string>();
            danhsachmshs = quanlyhocsinh.SelectMSSV();
            if (!danhsachmshs.Contains(tbMaHS.Text))
            {
                MessageBox.Show("Có lỗi");
                return;
            }
            else
            {
                QuanLyLopDTO hs = new QuanLyLopDTO();
                hs.MaHS = tbMaHS.Text;
                hs.TenLop = cbLop.Text;
                if (quanlylop.Them(hs) == true)
                {
                    MessageBox.Show("thêm học sinh thành công");
                }
            }
            Load_DanhSachHocSinhChuaCoLop();
            Load_DanhSachHocSinh(cbLop.Text);

        }

        private void cbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> tenlop = new List<string>();

            tenlop =   quanlylop.SelectLop(cbKhoi.Text);
            cbLop.Items.Clear();
            foreach(string temp in tenlop)
            {
                cbLop.Items.Add(temp);
            }
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbMaHS.Enabled = true;
            btnThem.Enabled = true;
            Load_DanhSachHocSinh(cbLop.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            QuanLyLopDTO HS = new QuanLyLopDTO();
            HS.MaHS = tbMaHS.Text;
            HS.TenLop = cbLop.Text;
            List<string> danhsachlop = new List<string>();
            foreach(DataGridViewRow temp in dtgvDanhSachLop.Rows)
            {
                danhsachlop.Add(temp.Cells[0].Value.ToString());
            }
            if(danhsachlop.Contains(tbMaHS.Text)==false)
            {
                MessageBox.Show("Học sinh không có trong lớp");
                return;
            }
            else
            {
                if(quanlylop.Xoa(HS)==true)
                {
                    MessageBox.Show("Xóa học sinh khỏi lớp thành công");
                }
                else
                {
                    MessageBox.Show("Xóa học sinh khỏi lớp thật bại");
                    return;
                }
            }
            Load_DanhSachHocSinhChuaCoLop();
            Load_DanhSachHocSinh(cbLop.Text);
        }

        private void dtgvDanhSachLop_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dtgvDanhSachLop.CurrentCell == null)
            {
                dtgv_hang = -1;
            }
            else
                dtgv_hang = dtgvDanhSachLop.CurrentCell.RowIndex;
            if (dtgv_hang >= 0)
            {
                if (dtgvDanhSachLop.Rows[dtgv_hang].Cells[0].Value != null)
                {
                    tbMaHS.Text = dtgvDanhSachLop.Rows[dtgv_hang].Cells[0].Value.ToString();
                }
                btnXoa.Enabled = true;
                btnThem.Enabled = false;

            }
        }

        private void dtgvDSHSChuaCoLop_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvDSHSChuaCoLop.CurrentCell == null)
            {
                dtgv_hang = -1;
            }
            else
                dtgv_hang = dtgvDSHSChuaCoLop.CurrentCell.RowIndex;
            if (dtgv_hang >= 0)
            {
                if (dtgvDSHSChuaCoLop.Rows[dtgv_hang].Cells[0].Value != null)
                {
                    tbMaHS.Text = dtgvDSHSChuaCoLop.Rows[dtgv_hang].Cells[0].Value.ToString();
                }

                if (cbLop.Text != "")
                {
                    btnThem.Enabled = true;
                }
                btnXoa.Enabled = false;

            }
        }

        private void Load_DanhSachHocSinhChuaCoLop()
        {
            List<QuanLyHocSinhDTO> DanhSachHocSinh = quanlyhocsinh.SelectHSChuaCoLoP();
            if (DanhSachHocSinh == null)
            {
                MessageBox.Show("Có lỗi khi lấy Món ăn từ DB");
                return;
            }
            dtgvDSHSChuaCoLop.DataSource = null;

            dtgvDSHSChuaCoLop.AutoGenerateColumns = false;
            dtgvDSHSChuaCoLop.AllowUserToAddRows = false;
            dtgvDSHSChuaCoLop.DataSource = DanhSachHocSinh;


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvDSHSChuaCoLop.DataSource];
            myCurrencyManager.Refresh();
        }

        
    }
}
