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
    public partial class ucQuanlyDiem : UserControl
    {
        public ucQuanlyDiem()
        {
            InitializeComponent();
        }
        private bool dang_sua = false;
        private int dtgv_hang = -1;
        private ucThamso a = new ucThamso();
        private QuanLyLopBUS quanlylop;
        private QuanLyDiemBUS quanlydiem;

        private bool check_data()
        {
            if (string.IsNullOrWhiteSpace(cbHK.Text))
            {
                MessageBox.Show("Chưa nhập học kỳ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbHK.Focus();
                return false;
            }
            string temp_cbHocKy = string.Empty;
            foreach (var items in cbHK.Items)
            {
                temp_cbHocKy += items.ToString();
            }
            if (!temp_cbHocKy.Contains(cbHK.Text))
            {
                MessageBox.Show("Học kỳ không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbHK.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cblop.Text))
            {
                MessageBox.Show("Chưa nhập lớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbHK.Focus();
                return false;
            }
            string temp_cbLop = string.Empty;
            foreach (var items in cblop.Items)
            {
                temp_cbLop += items.ToString();
            }
            if (!temp_cbLop.Contains(cblop.Text))
            {
                MessageBox.Show("Lớp không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cblop.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbMonHoc.Text))
            {
                MessageBox.Show("Chưa nhập môn học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbMonHoc.Focus();
                return false;
            }
            string temp_cbMonHoc = string.Empty;
            foreach (var items in cbMonHoc.Items)
            {
                temp_cbMonHoc += items.ToString();
            }
            if (!temp_cbMonHoc.Contains(cbMonHoc.Text))
            {
                MessageBox.Show("Môn học không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbMonHoc.Focus();
                return false;
            }

            return true;
        }

        private void ucQuanlyDiem_Load(object sender, EventArgs e)
        {
            quanlydiem = new QuanLyDiemBUS();
            quanlylop = new QuanLyLopBUS();
            List<QuanLyDiemDTO> danhsachmon= quanlydiem.SelectMon();

            foreach(var temp in danhsachmon)
            {
                cbMonHoc.Items.Add(temp.Mon);
            }

            cblop.Items.Clear();
            List<string> tenlop = new List<string>();

            tenlop = quanlylop.SelectLop("K10");
            foreach (string temp in tenlop)
            {
                cblop.Items.Add(temp);
            }
            tenlop = quanlylop.SelectLop("K11");
            foreach (string temp in tenlop)
            {
                cblop.Items.Add(temp);
            }
            tenlop = quanlylop.SelectLop("K12");
            foreach (string temp in tenlop)
            {
                cblop.Items.Add(temp);
            }
        }

        private void btnLayDanhSach_Click(object sender, EventArgs e)
        {
            if (check_data())
            {
                Load_DanhSachHocSinh();
            }
        }

        private void Load_DanhSachHocSinh()
        {
            QuanLyDiemDTO QLD = new QuanLyDiemDTO();
            QLD.Lop = cblop.Text;
            QLD.Mon = cbMonHoc.Text;
            QLD.HocKy = cbHK.Text;
            List<QuanLyDiemDTO> DanhSachHocSinh = quanlydiem.SelectHS(QLD);
            if (DanhSachHocSinh == null)
            {
                MessageBox.Show("Có lỗi khi lấy danh sách từ DB");
                return;
            }
            dtgvDanhSachHocSinh.DataSource = null;

            dtgvDanhSachHocSinh.AutoGenerateColumns = false;
            dtgvDanhSachHocSinh.AllowUserToAddRows = false;
            dtgvDanhSachHocSinh.DataSource = DanhSachHocSinh;


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvDanhSachHocSinh.DataSource];
            myCurrencyManager.Refresh();
        }

        private void dtgvDanhSachHocSinh_SelectionChanged(object sender, EventArgs e)
        {
            if (dang_sua == false)
            {
                if (dtgvDanhSachHocSinh.CurrentCell == null)
                {
                    dtgv_hang = -1;
                }
                else
                    dtgv_hang = dtgvDanhSachHocSinh.CurrentCell.RowIndex;
                if (dtgv_hang >= 0)
                {
                    tbMaHS.Text = dtgvDanhSachHocSinh.Rows[dtgv_hang].Cells[0].Value.ToString();
                    tbDiem15.Text = dtgvDanhSachHocSinh.Rows[dtgv_hang].Cells[2].Value.ToString();
                    tbDiem45.Text = dtgvDanhSachHocSinh.Rows[dtgv_hang].Cells[3].Value.ToString();
                    tbDiemCuoiKy.Text = dtgvDanhSachHocSinh.Rows[dtgv_hang].Cells[4].Value.ToString();
                    if (dtgvDanhSachHocSinh.CurrentCell != dtgvDanhSachHocSinh[0, 0])
                    {
                        btnSua.Enabled = true;
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dang_sua = true;
            btnSua.Enabled = false;
            btnLamMoi.Enabled = false;
            cbHK.Enabled = false;
            cblop.Enabled = false;
            cbMonHoc.Enabled = false;
            btnLayDanhSach.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            tbDiem15.Enabled = true;
            tbDiem45.Enabled = true;
            tbDiemCuoiKy.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(dang_sua)
            {
                int temp;
                if (int.TryParse(tbDiem15.Text, out temp) == false || int.Parse(tbDiem15.Text) < 0 || int.Parse(tbDiem15.Text) > 10)
                {
                    MessageBox.Show("Điểm 15p không hợp lệ");
                    return;
                }
                if (int.TryParse(tbDiem45.Text, out temp) == false || int.Parse(tbDiem45.Text) < 0 || int.Parse(tbDiem45.Text) > 10)
                {
                    MessageBox.Show("Điểm 45p không hợp lệ");
                    return;
                }
                if (int.TryParse(tbDiemCuoiKy.Text, out temp) == false || int.Parse(tbDiemCuoiKy.Text) < 0 || int.Parse(tbDiemCuoiKy.Text) > 10)
                {
                    MessageBox.Show("Điểm cuối kỳ không hợp lệ");
                    return;
                }

                QuanLyDiemDTO QLD = new QuanLyDiemDTO();
                QLD.MaHS = tbMaHS.Text;
                QLD.Mon = cbMonHoc.Text;
                QLD.HocKy = cbHK.Text;
                QLD.Diem15Ph = tbDiem15.Text;
                QLD.Diem45Ph = tbDiem45.Text;
                QLD.DiemHocKy = tbDiemCuoiKy.Text;
                if(quanlydiem.Sua(QLD)==true)
                {
                    MessageBox.Show("Cập nhật điểm thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật điểm thất bại");
                    return;
                }

                dang_sua = false;
                cbHK.Enabled = true;
                cblop.Enabled = true;
                cbMonHoc.Enabled = true;
                btnLayDanhSach.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                tbDiem15.Enabled = false;
                tbDiem45.Enabled = false;
                btnSua.Enabled = true;
                btnLamMoi.Enabled = true;
                tbDiemCuoiKy.Enabled = false;
            }
            Load_DanhSachHocSinh();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dang_sua = false;
            cbHK.Enabled = true;
            cblop.Enabled = true;
            cbMonHoc.Enabled = true;
            btnLayDanhSach.Enabled = true;
            btnSua.Enabled = true;
            btnLamMoi.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            tbDiem15.Enabled = false;
            tbDiem45.Enabled = false;
            tbDiemCuoiKy.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            QuanLyDiemDTO QLD = new QuanLyDiemDTO();
            QLD.Lop = cblop.Text;
            QLD.Mon = cbMonHoc.Text;
            QLD.HocKy = cbHK.Text;
            if(quanlydiem.LamMoi(QLD)==true)
            {
                MessageBox.Show("Làm mới bảng điểm lớp thành công");
            }
            else
            {
                MessageBox.Show("Làm mới bảng điểm lớp thất bại");
                return;
            }

            Load_DanhSachHocSinh();
        }
    }
}
