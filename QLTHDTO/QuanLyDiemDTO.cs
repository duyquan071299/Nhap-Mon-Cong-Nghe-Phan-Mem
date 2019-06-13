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
        private string iHocKy;
        private string sLop;
        private string sHoTen;
        private string sMaHS;
        private string fDiem15Ph;
        private string fDiem45Ph;
        private string fDiemHocKy;
        private float fDiemTB;

        public QuanLyDiemDTO() { }

        public string HocKy { get => iHocKy; set => iHocKy = value; }
        public string Diem15Ph { get => fDiem15Ph; set => fDiem15Ph = value; }
        public string Diem45Ph { get => fDiem45Ph; set => fDiem45Ph = value; }
        public string DiemHocKy { get => fDiemHocKy; set => fDiemHocKy = value; }
        public string Lop { get => sLop; set => sLop = value; }
        public string Mon { get => sMon; set => sMon = value; }
        public string HoTen { get => sHoTen; set => sHoTen = value; }
        public float DiemTB { get => fDiemTB; set => fDiemTB = value; }
        public string MaHS { get => sMaHS; set => sMaHS = value; }
    }
}
