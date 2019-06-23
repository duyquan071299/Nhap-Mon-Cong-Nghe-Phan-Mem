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
    public partial class ucThamso : UserControl
    {
        public ucThamso()
        {
            InitializeComponent();

            qlts = new QuanLyThamSoBUS();
        }

        private bool them = false;
        private bool sua = false;
        private int dtgv_hang = -1;
        private QuanLyThamSoBUS qlts;

        private bool check_data()
        {
            if (string.IsNullOrWhiteSpace(cbTenThamSo.Text))
            {
                MessageBox.Show("Chưa nhập tên tham số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbTenThamSo.Focus();
                return false;
            }
            string temp_cbTenThamSo = string.Empty;
            foreach (var items in cbTenThamSo.Items)
            {
                temp_cbTenThamSo += items.ToString();
            }
            if (!temp_cbTenThamSo.Contains(cbTenThamSo.Text))
            {
                MessageBox.Show("Tên tham số không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbTenThamSo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbGiaTri.Text))
            {
                MessageBox.Show("Chưa giá trị", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbGiaTri.Focus();
                return false;
            }
            

            return true;
        }

        private void ucThamso_Load(object sender, EventArgs e)
        {
            Load_DanhSachThamSo();
            cbTenThamSo.Items.Add("Số tuổi tối thiểu");
            cbTenThamSo.Items.Add("Số tuổi tối đa");
            cbTenThamSo.Items.Add("Sỉ số lớp tối đa");
            cbTenThamSo.Items.Add("Điểm đạt môn");
            cbTenThamSo.Items.Add("Tên môn học");
            cbTenThamSo.Items.Add("Tên lớp K10");
            cbTenThamSo.Items.Add("Tên lớp K11");
            cbTenThamSo.Items.Add("Tên lớp K12");
        }

        public void Load_DanhSachThamSo()
        {
            List<ThamSoDTO> DanhSachThamSo = qlts.SelectAll();
            if (DanhSachThamSo == null)
            {
                MessageBox.Show("Có lỗi khi lấy tham số từ DB");
                return;
            }
            dtgvThamSo.DataSource = null;

            dtgvThamSo.AutoGenerateColumns = false;
            dtgvThamSo.AllowUserToAddRows = false;
            dtgvThamSo.DataSource = DanhSachThamSo;


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvThamSo.DataSource];
            myCurrencyManager.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            cbTenThamSo.Enabled = true;
            btnHuy.Enabled = true;
            tbGiaTri.Enabled = true;
            tbGiaTri.Clear();
            foreach(DataGridViewRow temp in dtgvThamSo.Rows)
            {
                if (temp.Cells[0].Value.ToString() == "Sỉ số lớp tối đa")
                {
                    cbTenThamSo.Items.Remove("Sỉ số lớp tối đa");
                }
                if (temp.Cells[0].Value.ToString() == "Số tuổi tối thiểu")
                {
                    cbTenThamSo.Items.Remove("Số tuổi tối thiểu");
                }
                if (temp.Cells[0].Value.ToString() == "Số tuổi tối đa")
                {
                    cbTenThamSo.Items.Remove("Số tuổi tối đa");
                }
                if(temp.Cells[0].Value.ToString()=="Điểm đạt môn")
                {
                    cbTenThamSo.Items.Remove("Điểm đạt môn");
                }
            }

        }
        

        private void btnSua_Click(object sender, EventArgs e)
        {
            sua = true;
            tbGiaTriMoi.Clear();
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnHuy.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            lbGiaTriMoi.Visible = true;
            tbGiaTriMoi.Visible = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(them)
            {
                if (check_data())
                {
                    if (cbTenThamSo.Text == "Sỉ số lớp tối đa" || cbTenThamSo.Text == "Số tuổi tối thiệu"
                            || cbTenThamSo.Text == "Sỉ số lớp tối thiểu" || cbTenThamSo.Text == "Điểm đạt môn")
                    {
                        int temp;
                        if (int.TryParse(tbGiaTri.Text, out temp) == false || int.Parse(tbGiaTri.Text) <= 0)
                        {
                            MessageBox.Show("Giá trị không hợp lệ");
                            return;
                        }
                        if (cbTenThamSo.Text == "Điểm đạt môn" && int.Parse(tbGiaTri.Text) > 10)
                        {
                            MessageBox.Show("Giá trị không hợp lệ");
                        }
                    }
                    ThamSoDTO TS = new ThamSoDTO();
                    TS.STenThamSo = cbTenThamSo.Text;
                    TS.SGiaTri = tbGiaTri.Text;
                    if (cbTenThamSo.Text == "Tên lớp K10" || cbTenThamSo.Text == "Tên lớp K11" || cbTenThamSo.Text == "Tên lớp K12")
                    {
                        List<string> lopdaco = new List<string>();
                        foreach (DataGridViewRow temp in dtgvThamSo.Rows)
                        {
                            if (temp.Cells[0].Value.ToString() == "Tên lớp K10" || temp.Cells[0].Value.ToString() == "Tên lớp K11" || temp.Cells[0].Value.ToString() == "Tên lớp K12")
                            {
                                lopdaco.Add(temp.Cells[1].Value.ToString());
                            }
                        }
                        if (lopdaco.Contains(tbGiaTri.Text))
                        {
                            MessageBox.Show("Thêm lớp thất bại, lớp đã có");
                            return;
                        }
                        else
                        {
                            if (qlts.themlop(TS) == true)
                            {
                                MessageBox.Show("Thêm tham số tên lớp thành công");
                            }
                            else
                            {
                                MessageBox.Show("Thêm tham số tên lớp thất bại");
                            }
                        }
                    }
                    else if (cbTenThamSo.Text == "Tên môn học")
                    {
                        List<string> monhocdaco = new List<string>();
                        foreach (DataGridViewRow temp in dtgvThamSo.Rows)
                        {
                            if (temp.Cells[0].Value.ToString() == "Tên môn học")
                            {
                                monhocdaco.Add(temp.Cells[1].Value.ToString());
                            }
                        }
                        if (monhocdaco.Contains(tbGiaTri.Text))
                        {
                            MessageBox.Show("Thêm môn học thất bại, môn học đã có");
                            return;
                        }
                        else
                        {
                            if (qlts.themmonhoc(TS) == true)
                            {
                                MessageBox.Show("Thêm tham số tên môn học thành công");
                            }
                            else
                            {
                                MessageBox.Show("Thêm tham số tên môn học thất bại");
                            }
                        }
                    }
                    else
                    {
                        if (qlts.them(TS) == true)
                        {
                            MessageBox.Show("Thêm tham số thành công");
                        }
                        else
                        {
                            MessageBox.Show("Thêm tham số thất bại");
                        }
                    }
                    btnLuu.Enabled = false;
                    btnSua.Enabled = true;
                    btnThem.Enabled = true;
                    cbTenThamSo.Enabled = false;
                    btnHuy.Enabled = false;
                    tbGiaTri.Enabled = false;
                    them = false;
                }
            }
            if (sua)
            {
                if (check_data())
                {
                    if (string.IsNullOrWhiteSpace(tbGiaTriMoi.Text))
                    {
                        MessageBox.Show("Chưa nhập giá trị mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbTenThamSo.Focus();
                        return;
                    }
                    ThamSoDTO TS = new ThamSoDTO();
                    TS.STenThamSo = cbTenThamSo.Text;
                    TS.SGiaTri = tbGiaTri.Text;
                    TS.SGiaTriMoi = tbGiaTriMoi.Text;
                    if (cbTenThamSo.Text == "Tên lớp K10" || cbTenThamSo.Text == "Tên lớp K11" || cbTenThamSo.Text == "Tên lớp K12")
                    {
                        List<string> lopdaco = new List<string>();
                        foreach (DataGridViewRow temp in dtgvThamSo.Rows)
                        {
                            if (temp.Cells[0].Value.ToString() == "Tên lớp K10" || temp.Cells[0].Value.ToString() == "Tên lớp K11" || temp.Cells[0].Value.ToString() == "Tên lớp K12")
                            {
                                lopdaco.Add(temp.Cells[1].Value.ToString());
                            }
                        }
                        if (lopdaco.Contains(tbGiaTriMoi.Text))
                        {
                            MessageBox.Show("Sửa lớp thất bại, lớp đã có");
                            return;
                        }
                        else
                        {
                            if (qlts.sualop(TS) == true)
                            {
                                MessageBox.Show("Sửa tham số tên lớp thành công");
                            }
                            else
                            {
                                MessageBox.Show("Sửa tham số tên lớp thất bại");
                            }
                        }
                    }
                    else if (cbTenThamSo.Text == "Tên môn học")
                    {
                        List<string> monhocdaco = new List<string>();
                        foreach (DataGridViewRow temp in dtgvThamSo.Rows)
                        {
                            if (temp.Cells[0].Value.ToString() == "Tên môn học")
                            {
                                monhocdaco.Add(temp.Cells[1].Value.ToString());
                            }
                        }
                        if (monhocdaco.Contains(tbGiaTriMoi.Text))
                        {
                            MessageBox.Show("Sửa môn học thất bại, môn học đã có");
                            return;
                        }
                        else
                        {
                            if (qlts.suamonhoc(TS) == true)
                            {
                                MessageBox.Show("Sửa tham số tên môn học thành công");
                            }
                            else
                            {
                                MessageBox.Show("Sửa tham số tên môn học thất bại");
                            }
                        }
                    }
                    else
                    {
                        if (qlts.sua(TS) == true)
                        {
                            MessageBox.Show("Sửa tham số thành công");
                        }
                        else
                        {
                            MessageBox.Show("Sửa tham số thất bại");
                        }
                    }
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    btnSua.Enabled = true;
                    btnThem.Enabled = true;
                    lbGiaTriMoi.Visible = false;
                    tbGiaTriMoi.Visible = false;
                    sua = false;
                }
            }
            Load_DanhSachThamSo();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            tbGiaTri.Enabled = false;
            cbTenThamSo.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            lbGiaTriMoi.Visible = false;
            tbGiaTriMoi.Visible = false;
            if (them)
            {
                them = false;
            }
            if (sua)
            {
                sua = false;
            }
        }

        private void dtgvThamSo_SelectionChanged(object sender, EventArgs e)
        {
            if (them == false && sua == false)
            {
                if (dtgvThamSo.CurrentCell == null)
                {
                    dtgv_hang = -1;
                }
                else
                    dtgv_hang = dtgvThamSo.CurrentCell.RowIndex;
                if (dtgv_hang >= 0)
                {
                    cbTenThamSo.Text = dtgvThamSo.Rows[dtgv_hang].Cells[0].Value.ToString();
                    tbGiaTri.Text = dtgvThamSo.Rows[dtgv_hang].Cells[1].Value.ToString();
                    if (dtgvThamSo.CurrentCell != dtgvThamSo[0, 0])
                    {
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ThamSoDTO tsdto = new ThamSoDTO();
            tsdto.STenThamSo = cbTenThamSo.Text;
            tsdto.SGiaTri = tbGiaTri.Text;
            if(cbTenThamSo.Text=="Sỉ số lớp tối đa" || cbTenThamSo.Text == "Số tuổi tối thiểu"
                    || cbTenThamSo.Text == "Số tuổi tối đa"|| cbTenThamSo.Text == "Điểm đạt môn")
            {
                MessageBox.Show("Tham số không thể xóa");
                return;
            }
            else if(tsdto.STenThamSo=="Tên lớp K10" || tsdto.STenThamSo == "Tên lớp K11" || tsdto.STenThamSo == "Tên lớp K12")
            {
                if(qlts.xoalop(tsdto)==true)
                {
                    MessageBox.Show("Xóa lớp thành công");
                }
                else
                {
                    MessageBox.Show("Xóa lớp thất bại");
                    return;
                }
            }
            else if(tsdto.STenThamSo=="Tên môn học")
            {
                if(qlts.xoamonhoc(tsdto))
                {
                    MessageBox.Show("Xóa môn học thành công");
                }
                else
                {
                    MessageBox.Show("Xóa môn hôc thất bại");
                    return;
                }
            }
            else
            {
                if (qlts.xoa(tsdto) == true)
                {
                    MessageBox.Show("Xóa tham số thành công");
                }
                else
                {
                    MessageBox.Show("Xóa tham số thất bại");
                    return;
                }
            }
            btnXoa.Enabled = false;
            Load_DanhSachThamSo();
        }
    }
}
