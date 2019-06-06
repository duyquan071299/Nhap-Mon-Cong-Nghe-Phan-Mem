using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHDTO
{
    class PhanQuyenDTO
    {
        private string sHoTen;
        private string sTenDangNhap;
        private string sChucVu;

        public string HoTen { get => sHoTen; set => sHoTen = value; }
        public string TenDangNhap { get => sTenDangNhap; set => sTenDangNhap = value; }
        public string ChucVu { get => sChucVu; set => sChucVu = value; }
    }
}
