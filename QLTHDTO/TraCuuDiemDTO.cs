using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHDTO
{
    class TraCuuDiemDTO
    {
        private string sMSHocSInh;
        private string sHoTenHS;
        private string sMon;
        private int iHocKy;
        private float fDiemMieng;
        private float fDiem15Ph;
        private float fDiem45Ph;
        private float fDiemGK;
        private float fDiemCK;
        private float fDiemTB;

        public string MSHocSInh { get => sMSHocSInh; set => sMSHocSInh = value; }
        public string HoTenHS { get => sHoTenHS; set => sHoTenHS = value; }
        public string Mon { get => sMon; set => sMon = value; }
        public int HocKy { get => iHocKy; set => iHocKy = value; }
        public float DiemMieng { get => fDiemMieng; set => fDiemMieng = value; }
        public float Diem15Ph { get => fDiem15Ph; set => fDiem15Ph = value; }
        public float Diem45Ph { get => fDiem45Ph; set => fDiem45Ph = value; }
        public float DiemGK { get => fDiemGK; set => fDiemGK = value; }
        public float DiemCK { get => fDiemCK; set => fDiemCK = value; }
        public float DiemTB { get => fDiemTB; set => fDiemTB = value; }
    }
}
