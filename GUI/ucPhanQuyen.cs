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
    public partial class ucPhanQuyen : UserControl
    {
        private bool ChinhSua = false;
        public ucPhanQuyen()
        {
            
            InitializeComponent();
           
        }
        private PhanQuyenBUS pqbPhanQuyen;
        private List<string> pbdPhanQuyen;
        private void btnTimNguoiDung_Click(object sender, EventArgs e)
        {
            dtgvUser.Rows.Clear();
            btnSuaQuyen.Enabled = true;
            btnXoaNguoiDung.Enabled = true;
            if (tbTenDangNhap.Text == "")
            {
                MessageBox.Show("Chưa điền tên đăng nhập");
                return;
            }
            pbdPhanQuyen = new List<string>();
            if (pqbPhanQuyen.CheckTenDangNhap(tbTenDangNhap.Text))
            {
                pbdPhanQuyen = pqbPhanQuyen.TimNguoiDung(tbTenDangNhap.Text);
                dtgvUser.Rows.Add();
                dtgvUser.Rows[0].Cells[5].ReadOnly = true;
                dtgvUser.Rows[0].Cells[1].ReadOnly = true;
                dtgvUser.Rows[0].Cells[2].ReadOnly = true;
                dtgvUser.Rows[0].Cells[3].ReadOnly = true;
                dtgvUser.Rows[0].Cells[4].ReadOnly = true;
                dtgvUser.Rows[0].Cells[0].Value = tbTenDangNhap.Text;
                if (pbdPhanQuyen.Contains("ADMIN"))
                {
                    dtgvUser.Rows[0].Cells[5].Value = true;
                }
                if (pbdPhanQuyen.Contains("EDIT"))
                {
                    dtgvUser.Rows[0].Cells[1].Value = true;
                    //dtgvUser.Rows[0].Cells[1].ReadOnly = false;
                }
                if (pbdPhanQuyen.Contains("DELETE"))
                {
                    dtgvUser.Rows[0].Cells[2].Value = true;
                    //dtgvUser.Rows[0].Cells[2].ReadOnly = false;
                }
                if (pbdPhanQuyen.Contains("ADD"))
                {
                    dtgvUser.Rows[0].Cells[3].Value = true;
                    //dtgvUser.Rows[0].Cells[3].ReadOnly = false;
                }
                if (pbdPhanQuyen.Contains("EXPORT"))
                {
                    dtgvUser.Rows[0].Cells[4].Value = true;
                    //dtgvUser.Rows[0].Cells[4].ReadOnly = false;
                }
       
            }
            else
            {
                MessageBox.Show("Người dùng không tồn tại");
            }
        }

        private void ucPhanQuyen_Load(object sender, EventArgs e)
        {
            pqbPhanQuyen = new PhanQuyenBUS();
            btnXong.Hide();
            btnSuaQuyen.Enabled = false;
            btnXoaNguoiDung.Enabled = false;
        }

        private void btnSuaQuyen_Click(object sender, EventArgs e)
        {
            dtgvUser.Rows[0].Cells[5].ReadOnly = false;
            dtgvUser.Rows[0].Cells[1].ReadOnly = false;
            dtgvUser.Rows[0].Cells[2].ReadOnly = false;
            dtgvUser.Rows[0].Cells[3].ReadOnly = false;
            dtgvUser.Rows[0].Cells[4].ReadOnly = false;
            ChinhSua = true;
            btnXong.Show();
            btnTimNguoiDung.Enabled = false;
            btnXoaNguoiDung.Enabled = false;
            btnSuaQuyen.Hide();
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            dtgvUser.Rows[0].Cells[5].ReadOnly = true;
            dtgvUser.Rows[0].Cells[1].ReadOnly = true;
            dtgvUser.Rows[0].Cells[2].ReadOnly = true;
            dtgvUser.Rows[0].Cells[3].ReadOnly = true;
            dtgvUser.Rows[0].Cells[4].ReadOnly = true;
            btnSuaQuyen.Show();
            btnTimNguoiDung.Enabled = true;
            btnXoaNguoiDung.Enabled = true;
            btnXong.Hide();
            ChinhSua = false;
        }

        private void dtgvUser_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (ChinhSua == false)
                return;
            string MaUser = pqbPhanQuyen.getMaUser(dtgvUser.Rows[0].Cells[0].Value.ToString());
            string MaQuyen = pqbPhanQuyen.getMaQuyen(dtgvUser.CurrentCell.OwningColumn.HeaderText);
            pqbPhanQuyen.ChinhSuaQuyen(MaUser, MaQuyen, bool.Parse(dtgvUser.CurrentCell.Value.ToString()));
        }

        private void btnXoaNguoiDung_Click(object sender, EventArgs e)
        {
            string MaUser = pqbPhanQuyen.getMaUser(dtgvUser.Rows[0].Cells[0].Value.ToString());
            if(pqbPhanQuyen.XoaNguoiDung(MaUser))
            {
                MessageBox.Show("Xóa người dùng thành công");
                dtgvUser.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Xóa người dùng thất bại");
            }
            

        }

        private void btnTaoNguoiDung_Click(object sender, EventArgs e)
        {
            if(tbTK.Text=="" || tbMK.Text=="")
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin");
                return;
            }
            else
            {
                if(pqbPhanQuyen.TaoNguoiDung(tbTK.Text,tbMK.Text))
                {
                    MessageBox.Show("Thêm người dùng thành công");
                }
                else
                {
                    MessageBox.Show("Thêm người dùng thất bại hoặc tên đăng nhập bị trùng");
                    return;
                }
                  
            }
        }
    }
}
