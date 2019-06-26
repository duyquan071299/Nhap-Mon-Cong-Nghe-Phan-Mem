using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHDTO
{
    public class DangNhapDTO
    {
        private string sTenDangNhap;
        private string sMatKhau;

        public string TenDangNhap { get => sTenDangNhap; set => sTenDangNhap = value; }
        public string MatKhau { get => sMatKhau; set => sMatKhau = value; }
    }
}
