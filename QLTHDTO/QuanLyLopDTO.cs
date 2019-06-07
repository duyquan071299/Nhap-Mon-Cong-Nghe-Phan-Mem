using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHDTO
{
    public class QuanLyLopDTO
    {
        private string sTTLop;
        private string sMaHS;
        private string sGioiTinh;
        private string sHoTen;
        private DateTime dtNgaySinh;
        private string sMaKhoi;
        private string sTenLop;

        public string TTLop { get => sTTLop; set => sTTLop = value; }
        public string MaHS { get => sMaHS; set => sMaHS = value; }
        public string GioiTinh { get => sGioiTinh; set => sGioiTinh = value; }
        public string HoTen { get => sHoTen; set => sHoTen = value; }
        public DateTime NgaySinh { get => dtNgaySinh; set => dtNgaySinh = value; }
        public string MaKhoi { get => sMaKhoi; set => sMaKhoi = value; }
        public string TenLop { get => sTenLop; set => sTenLop = value; }
    }
}
