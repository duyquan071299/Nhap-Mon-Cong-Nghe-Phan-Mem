using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHDTO
{
    public class ThamSoDTO
    {
        private string sTenThamSo;
        private string sGiaTri;
        private string sGiaTriMoi;

        public string STenThamSo { get => sTenThamSo; set => sTenThamSo = value; }
        public string SGiaTri { get => sGiaTri; set => sGiaTri = value; }
        public string SGiaTriMoi { get => sGiaTriMoi; set => sGiaTriMoi = value; }
    }
}
