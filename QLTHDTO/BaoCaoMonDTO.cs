﻿using System;
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
        private string iSiSo;
        private string iSLDat;
        private string fTiLeDat;
        private string sDiemDat;

        public BaoCaoMonDTO() { }

        public string HocKy { get => sHocKy; set => sHocKy = value; }
        public string Mon { get => sMon; set => sMon = value; }
        public string Lop { get => sLop; set => sLop = value; }
        public string SiSo { get => iSiSo; set => iSiSo = value; }
        public string SLDat { get => iSLDat; set => iSLDat = value; }
        public string TiLeDat { get => fTiLeDat; set => fTiLeDat = value; }
        public string DiemDat { get => sDiemDat; set => sDiemDat = value; }
    }
}
