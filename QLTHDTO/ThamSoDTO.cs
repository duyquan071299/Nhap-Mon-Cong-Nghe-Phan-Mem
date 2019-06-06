using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHDTO
{
    class ThamSoDTO
    {
        private DateTime dtNgaySinhLonNhat;
        private DateTime dtNgaySinhNhoNhat;
        private int iSiSoToiDa;
        private float fDiemTBDatMonToiThieu;
        private float fDiemTBDatToiThieu;
        private float fSoDiemToiDa;
        private float fSoDiemToiThieu;
        private float fSoLuongMonHoc;

        public DateTime NgaySinhLonNhat { get => dtNgaySinhLonNhat; set => dtNgaySinhLonNhat = value; }
        public DateTime NgaySinhNhoNhat { get => dtNgaySinhNhoNhat; set => dtNgaySinhNhoNhat = value; }
        public int SiSoToiDa { get => iSiSoToiDa; set => iSiSoToiDa = value; }
        public float DiemTBDatMonToiThieu { get => fDiemTBDatMonToiThieu; set => fDiemTBDatMonToiThieu = value; }
        public float DiemTBDatToiThieu { get => fDiemTBDatToiThieu; set => fDiemTBDatToiThieu = value; }
        public float SoDiemToiDa { get => fSoDiemToiDa; set => fSoDiemToiDa = value; }
        public float SoDiemToiThieu { get => fSoDiemToiThieu; set => fSoDiemToiThieu = value; }
        public float SoLuongMonHoc { get => fSoLuongMonHoc; set => fSoLuongMonHoc = value; }
    }
}
