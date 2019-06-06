using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHDTO
{
    public class BaoCaoMonDTO
    {
        private string sMon;
        private string sHocKy;
        private string sLop;
        private int iSiSo;
        private int iSLDat;
        private float fTiLeDat;

        public string HocKy { get => sHocKy; set => sHocKy = value; }
        public string Mon { get => sMon; set => sMon = value; }
        public string SLop { get => sLop; set => sLop = value; }
        public int ISiSo { get => iSiSo; set => iSiSo = value; }
        public int ISLDat { get => iSLDat; set => iSLDat = value; }
        public float FTiLeDat { get => fTiLeDat; set => fTiLeDat = value; }
    }
}
