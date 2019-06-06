using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHDTO
{
    class TraCuuTTHSDTO
    {
        private string sMSHocSinh;
        private string sHoTenHS;
        private string sLop;
        private string sGioiTinh;
        private string sDiaChi;
        private string sSoDienThoai;
        private DateTime dtNgaySinh;

        public string MSHocSinh { get => sMSHocSinh; set => sMSHocSinh = value; }
        public string HoTenHS { get => sHoTenHS; set => sHoTenHS = value; }
        public string Lop { get => sLop; set => sLop = value; }
        public string GioiTinh { get => sGioiTinh; set => sGioiTinh = value; }
        public string DiaChi { get => sDiaChi; set => sDiaChi = value; }
        public string SoDienThoai { get => sSoDienThoai; set => sSoDienThoai = value; }
        public DateTime NgaySinh { get => dtNgaySinh; set => dtNgaySinh = value; }
    }
}
