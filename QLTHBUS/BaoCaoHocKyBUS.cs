using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTHDAL;
using QLTHDTO;

namespace QLTHBUS
{
    public class BaoCaoHocKyBUS
    {

        private BaoCaoHocKyDAL baocaoDAL;
        public BaoCaoHocKyBUS()
        {
            baocaoDAL = new BaoCaoHocKyDAL();
        }
        public List<BaoCaoHocKyDTO> TaoBaoCaoHocKy(string HocKy)
        {
            return baocaoDAL.BaoCaoHocKy(HocKy);
        }
    }
}
