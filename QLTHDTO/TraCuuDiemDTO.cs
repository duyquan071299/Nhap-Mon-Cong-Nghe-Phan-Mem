using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHDTO
{
    public class TraCuuDiemDTO
    {
        private string sMSHocSInh;
        private string sHoTenHS;
        private string sMon;
        private string iHocKy;
        private string fDiem15Ph;
        private string fDiem45Ph;
        private string fDiemCK;
        private string fDiemTB;
        private string sLop;

        public TraCuuDiemDTO() { }

        public string MSHocSInh { get => sMSHocSInh; set => sMSHocSInh = value; }
        public string HoTenHS { get => sHoTenHS; set => sHoTenHS = value; }
        public string Mon { get => sMon; set => sMon = value; }
        public string HocKy { get => iHocKy; set => iHocKy = value; }
        public string Diem15Ph { get => fDiem15Ph; set => fDiem15Ph = value; }
        public string Diem45Ph { get => fDiem45Ph; set => fDiem45Ph = value; }
        public string DiemCK { get => fDiemCK; set => fDiemCK = value; }
        public string DiemTB { get => fDiemTB; set => fDiemTB = value; }
        public string Lop { get => sLop; set => sLop = value; }
    }
}
