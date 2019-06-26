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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private DangNhapDTO dndUser;
        private DangNhapBUS dnbUser;
        private bool bcheckDn = false;

        public bool BcheckDn { get => bcheckDn; set => bcheckDn = value; }

        public string getUser()
        {
            return tbTenDangNhap.Text;
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            dndUser = new DangNhapDTO();
            dnbUser = new DangNhapBUS();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(tbTenDangNhap.Text=="" || tbMatKhau.Text=="")
            {
                MessageBox.Show("Chưa điền đầy đủ thông tin");
                return;
            }

            dndUser.TenDangNhap = tbTenDangNhap.Text;
            dndUser.MatKhau = tbMatKhau.Text;

            if(dnbUser.DangNhap(dndUser)==true)
            {
                BcheckDn = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }
    }
}
