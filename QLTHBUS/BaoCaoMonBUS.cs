using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTHDAL;
using QLTHDTO;

namespace QLTHBUS
{
    public class BaoCaoMonBUS
    {
        private BaoCaoMonDAL baocaoDAL;
        public BaoCaoMonBUS()
        {
            baocaoDAL = new BaoCaoMonDAL();
        }
        public List<BaoCaoMonDTO> TaoBaoCaoMon(BaoCaoMonDTO DTO)
        {
            return baocaoDAL.BaoCaoMon(DTO);
        }
    }
}
