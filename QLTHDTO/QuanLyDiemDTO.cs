using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHDTO
{
    public class QuanLyDiemDTO
    {
        private string sMon;
        private int iHocKy;
        private string sLop;
        private string sHoTen;
        private string sGioiTinh;
        private float fDiem15Ph;
        private float fDiem45Ph;
        private float fDiemHocKy;
        private float fDiemTB;

        public int HocKy { get => iHocKy; set => iHocKy = value; }
        public float Diem15Ph { get => fDiem15Ph; set => fDiem15Ph = value; }
        public float Diem45Ph { get => fDiem45Ph; set => fDiem45Ph = value; }
        public float DiemHocKy { get => fDiemHocKy; set => fDiemHocKy = value; }
        public string Lop { get => sLop; set => sLop = value; }
        public string Mon { get => sMon; set => sMon = value; }
        public string HoTen { get => sHoTen; set => sHoTen = value; }
        public string GioiTinh { get => sGioiTinh; set => sGioiTinh = value; }
        public float DiemTB { get => fDiemTB; set => fDiemTB = value; }
    }
}
