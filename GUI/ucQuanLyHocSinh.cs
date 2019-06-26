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
    public partial class ucQuanLyHocSinh : UserControl
    {
        public ucQuanLyHocSinh()
        {
            InitializeComponent();
        }
        private ucThamso a = new ucThamso();
        private QuanLyHocSinhBUS qlhsBus;
        private int dtgv_hang = -1;
        private bool dang_them = false;
        private bool dang_sua = false;
        private PhanQuyenBUS pqbPhanQuyen;
        private string sCurrentUser;

        public string CurrentUser { get => sCurrentUser; set => sCurrentUser = value; }

        private bool checkdata()
        {
            a.Load_DanhSachThamSo();
            string TuoiToiThieu = string.Empty;
            string TuoiToiDa = string.Empty;
            foreach (DataGridViewRow temp in a.dtgvThamSo.Rows)
            {
                if (temp.Cells[0].Value.ToString() == "Số tuổi tối thiểu")
                {
                    TuoiToiThieu = temp.Cells[1].Value.ToString();
                }
                if (temp.Cells[0].Value.ToString() == "Số tuổi tối đa")
                {
                    TuoiToiDa = temp.Cells[1].Value.ToString();
                }
            }

            if(int.Parse(DateTime.Now.Year.ToString())- int.Parse(dtpNgaySinh.Value.Year.ToString()) > int.Parse(TuoiToiDa) ||
                    int.Parse(DateTime.Now.Year.ToString()) - int.Parse(dtpNgaySinh.Value.Year.ToString()) < int.Parse(TuoiToiThieu) )
            {
                MessageBox.Show("Tuổi của học sinh không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbHoVaTen.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbHoVaTen.Text))
            {
                MessageBox.Show("Chưa nhập tên SV", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbHoVaTen.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbGioiTinh.Text))
            {
                MessageBox.Show("Chưa nhập giới tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbGioiTinh.Focus();
                return false;
            }
            string temp_cbGioiTinh = "";
            foreach (var items in cbGioiTinh.Items)
            {
                temp_cbGioiTinh += items.ToString();
            }
            if (!temp_cbGioiTinh.Contains(cbGioiTinh.Text))
            {
                MessageBox.Show("Giới tính không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbGioiTinh.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbNoiSinh.Text))
            {
                MessageBox.Show("Chưa nhập nơi sinh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNoiSinh.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbNguyenQuan.Text))
            {
                MessageBox.Show("Chưa nhập nguyên quán", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNguyenQuan.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbDanToc.Text))
            {
                MessageBox.Show("Chưa nhập dân tộc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbDanToc.Focus();
                return false;
            }
            string temp_cbDanToc = "";
            foreach (var items in cbDanToc.Items)
            {
                temp_cbDanToc += items.ToString();
            }
            if (!temp_cbDanToc.Contains(cbDanToc.Text))
            {
                MessageBox.Show("Dân tộc không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbDanToc.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbTonGiao.Text))
            {
                MessageBox.Show("Chưa nhập tôn giáo", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbTonGiao.Focus();
                return false;
            }
            string temp_cbTonGiao = "";
            foreach (var items in cbTonGiao.Items)
            {
                temp_cbTonGiao += items.ToString();
            }
            if (!temp_cbTonGiao.Contains(cbTonGiao.Text))
            {
                MessageBox.Show("Tôn giáo không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbTonGiao.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbHoKhau.Text))
            {
                MessageBox.Show("Chưa nhập hộ khẩu thường trú", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbHoKhau.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbUuTien.Text))
            {
                MessageBox.Show("Chưa nhập đối tượng ưu tiên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbUuTien.Focus();
                return false;
            }
            string temp_cbUuTien = "";
            foreach (var items in cbUuTien.Items)
            {
                temp_cbUuTien += items.ToString();
            }
            if (!temp_cbUuTien.Contains(cbUuTien.Text))
            {
                MessageBox.Show("Đối tượng ưu tiên không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbUuTien.Focus();
                return false;
            }
            
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            List<string> lsQuyen = pqbPhanQuyen.TimNguoiDung(CurrentUser);
            if (lsQuyen.Contains("ADD"))
            {
                dang_them = true;
                btnThem.Enabled = false;
                btnLuu.Enabled = true;
                btnBoQua.Enabled = true;
                foreach (Control temp in this.Controls)
                {
                    if (temp is TextBox)
                    {
                        ((TextBox)temp).Text = null;
                        ((TextBox)temp).Enabled = true;
                    }
                    if (temp is ComboBox)
                    {
                        ((ComboBox)temp).Text = null;
                        ((ComboBox)temp).Enabled = true;
                    }
                }
                dtpNgaySinh.Enabled = true;
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thêm");
            }
        }

        private void ucQuanLyHocSinh_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnBoQua.Enabled = false;
            qlhsBus = new QuanLyHocSinhBUS();
            pqbPhanQuyen = new PhanQuyenBUS();
            Load_DanhSachHocSinh();
        }

        private void Load_DanhSachHocSinh()
        {
            List<QuanLyHocSinhDTO> DanhSachHocSinh = qlhsBus.SelectAll();
            if (DanhSachHocSinh == null)
            {
                MessageBox.Show("Có lỗi khi lấy danh sách học sinh từ DB");
                return;
            }
            dtgvDanhSachSinhVien.DataSource = null;

            dtgvDanhSachSinhVien.AutoGenerateColumns = false;
            dtgvDanhSachSinhVien.AllowUserToAddRows = false;
            dtgvDanhSachSinhVien.DataSource = DanhSachHocSinh;
            

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvDanhSachSinhVien.DataSource];
            myCurrencyManager.Refresh();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (dang_them)
            {
                if (checkdata())
                {
                    int temp_MaHS = 17;
                    List<string> danhsachmshs = new List<string>();
                    danhsachmshs = qlhsBus.SelectMSSV();
                    if (danhsachmshs is null)
                    {
                        Random ran = new Random();
                        int temp1 = ran.Next(1, 9999);
                        temp_MaHS = temp_MaHS * 10000 + temp1;
                    }
                    else
                    {
                        do
                        {
                            Random ran = new Random();
                            int temp1 = ran.Next(1, 9999);
                            temp_MaHS = temp_MaHS * 10000 + temp1;
                        } while (danhsachmshs.Contains(temp_MaHS.ToString()));
                    }
                    QuanLyHocSinhDTO hs = new QuanLyHocSinhDTO();
                    hs.MaHS = temp_MaHS.ToString();
                    hs.HoTen = tbHoVaTen.Text;
                    hs.GioiTinh = cbGioiTinh.Text;
                    hs.NgaySinh = dtpNgaySinh.Value;
                    hs.NoiSinh = tbNoiSinh.Text;
                    hs.NguyenQuan = tbNguyenQuan.Text;
                    hs.DanToc = cbDanToc.Text;
                    hs.TonGiao = cbTonGiao.Text;
                    hs.HoKhauTT = tbHoKhau.Text;
                    hs.TenCha = tbTenCha.Text;
                    hs.TenMe = tbTenMe.Text;
                    hs.NNCha = tbNgheNghiepCha.Text;
                    hs.NNMe = tbNgheNghiepMe.Text;
                    hs.UuTien = cbUuTien.Text;
                    if (qlhsBus.Them(hs)==true)
                    {
                        MessageBox.Show("Thêm học sinh thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm học sinh thất bại. Vui lòng kiểm tra lại dữ liệu");
                    }

                    foreach (Control temp in this.Controls)
                    {
                        if (temp is TextBox)
                        {
                            ((TextBox)temp).Text = null;
                            ((TextBox)temp).Enabled = false;
                        }
                        if (temp is ComboBox)
                        {
                            ((ComboBox)temp).Text = null;
                            ((ComboBox)temp).Enabled = false;
                        }
                    }
                    dtpNgaySinh.Enabled = false;
                    btnThem.Enabled = true;
                    btnXoa.Enabled = false;
                    btnLuu.Enabled = false;
                    dang_them = false;

                }
            }
            if(dang_sua)
            {
                if (checkdata() == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn sửa ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.OK)
                    {
                        QuanLyHocSinhDTO hs = new QuanLyHocSinhDTO();
                        hs.MaHS = dtgvDanhSachSinhVien.Rows[dtgv_hang].Cells[0].Value.ToString();
                        hs.HoTen = tbHoVaTen.Text;
                        hs.GioiTinh = cbGioiTinh.Text;
                        hs.NgaySinh = dtpNgaySinh.Value;
                        hs.NoiSinh = tbNoiSinh.Text;
                        hs.NguyenQuan = tbNguyenQuan.Text;
                        hs.DanToc = cbDanToc.Text;
                        hs.TonGiao = cbTonGiao.Text;
                        hs.HoKhauTT = tbHoKhau.Text;
                        hs.TenCha = tbTenCha.Text;
                        hs.TenMe = tbTenMe.Text;
                        hs.NNCha = tbNgheNghiepCha.Text;
                        hs.NNMe = tbNgheNghiepMe.Text;
                        hs.UuTien = cbUuTien.Text;
                        if (qlhsBus.Sua(hs)==true)
                        {
                            MessageBox.Show("Sửa thông tin học sinh thành công");
                        }
                        else
                        {
                            MessageBox.Show("Sửa thông tin học sinh thất bại");
                        }

                        foreach (Control temp in this.Controls)
                        {
                            if (temp is TextBox)
                            {
                                ((TextBox)temp).Text = null;
                                ((TextBox)temp).Enabled = false;
                            }
                            if (temp is ComboBox)
                            {
                                ((ComboBox)temp).Text = null;
                                ((ComboBox)temp).Enabled = false;
                            }
                        }
                        dtpNgaySinh.Enabled = false;
                        btnLuu.Enabled = false;
                        btnXoa.Enabled = false;
                        dang_sua = false;
                    }

                }
            }
            Load_DanhSachHocSinh();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {

            foreach (Control temp in this.Controls)
            {
                if (temp is TextBox)
                {
                    ((TextBox)temp).Text = null;
                    ((TextBox)temp).Enabled = false;
                }
                if (temp is ComboBox)
                {
                    ((ComboBox)temp).Text = null;
                    ((ComboBox)temp).Enabled = false;
                }
            }
            dtpNgaySinh.Enabled = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = false;
            if (dang_them)
            {
                dang_them = false;
            }
            if(dang_sua)
            {
                dang_sua = false;
            }
        }

        private void dtgvDanhSachSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dang_them == false && dang_sua==false)
            {
                if (dtgvDanhSachSinhVien.CurrentCell == null)
                {
                    dtgv_hang = -1;
                }
                else
                    dtgv_hang = dtgvDanhSachSinhVien.CurrentCell.RowIndex;
                if (dtgv_hang >= 0)
                {
                    tbHoVaTen.Text = dtgvDanhSachSinhVien.Rows[dtgv_hang].Cells[1].Value.ToString();
                    cbGioiTinh.Text = dtgvDanhSachSinhVien.Rows[dtgv_hang].Cells[2].Value.ToString();
                    dtpNgaySinh.Value = (DateTime)dtgvDanhSachSinhVien.Rows[dtgv_hang].Cells[3].Value;
                    tbNoiSinh.Text = dtgvDanhSachSinhVien.Rows[dtgv_hang].Cells[4].Value.ToString();
                    tbNguyenQuan.Text = dtgvDanhSachSinhVien.Rows[dtgv_hang].Cells[5].Value.ToString();
                    cbDanToc.Text = dtgvDanhSachSinhVien.Rows[dtgv_hang].Cells[6].Value.ToString();
                    cbTonGiao.Text = dtgvDanhSachSinhVien.Rows[dtgv_hang].Cells[7].Value.ToString();
                    tbHoKhau.Text = dtgvDanhSachSinhVien.Rows[dtgv_hang].Cells[8].Value.ToString();
                    tbTenCha.Text = dtgvDanhSachSinhVien.Rows[dtgv_hang].Cells[9].Value.ToString();
                    tbNgheNghiepCha.Text = dtgvDanhSachSinhVien.Rows[dtgv_hang].Cells[10].Value.ToString();
                    tbTenMe.Text = dtgvDanhSachSinhVien.Rows[dtgv_hang].Cells[11].Value.ToString();
                    tbNgheNghiepMe.Text = dtgvDanhSachSinhVien.Rows[dtgv_hang].Cells[12].Value.ToString();
                    cbUuTien.Text = dtgvDanhSachSinhVien.Rows[dtgv_hang].Cells[13].Value.ToString();
                    if (dtgvDanhSachSinhVien.CurrentCell != dtgvDanhSachSinhVien[0, 0])
                    {
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            List<string> lsQuyen = pqbPhanQuyen.TimNguoiDung(CurrentUser);
            if (lsQuyen.Contains("DELETE"))
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa SV?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    QuanLyHocSinhDTO hs = new QuanLyHocSinhDTO();
                    hs.MaHS = dtgvDanhSachSinhVien.Rows[dtgv_hang].Cells[0].Value.ToString();
                    if (qlhsBus.Xoa(hs) == true)
                    {
                        MessageBox.Show("Xóa học sinh thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa học sinh thất bại");
                        return;
                    }
                }
                Load_DanhSachHocSinh();
                foreach (Control temp in this.Controls)
                {
                    if (temp is TextBox)
                    {
                        ((TextBox)temp).Text = null;
                        ((TextBox)temp).Enabled = false;
                    }
                    if (temp is ComboBox)
                    {
                        ((ComboBox)temp).Text = null;
                        ((ComboBox)temp).Enabled = false;
                    }
                }
                dtpNgaySinh.Enabled = false;
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                btnBoQua.Enabled = false;
            }
            else
            {
                MessageBox.Show("Bạn không có quyền xóa");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            List<string> lsQuyen = pqbPhanQuyen.TimNguoiDung(CurrentUser);
            if (lsQuyen.Contains("EDIT"))
            {
                btnBoQua.Enabled = true;
                dang_sua = true;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnLuu.Enabled = true;
                foreach (Control temp in this.Controls)
                {
                    if (temp is TextBox)
                    {
                        ((TextBox)temp).Enabled = true;
                    }
                    if (temp is ComboBox)
                    {
                        ((ComboBox)temp).Enabled = true;
                    }
                }
                dtpNgaySinh.Enabled = true;
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sửa");
            }
        }
    }
}
