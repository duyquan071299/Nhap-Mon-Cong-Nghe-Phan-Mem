using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTHDAL;
using QLTHDTO;

namespace QLTHBUS
{
    public class BaoCaoBUS
    {
        private BaoCaoDAL baocaoDAL;
        public BaoCaoBUS()
        {
            baocaoDAL = new BaoCaoDAL();
        }
        public List<BaoCaoMonDTO> TaoBaoCaoMon(BaoCaoMonDTO DTO)
        {
            return baocaoDAL.BaoCaoMon(DTO);
        }
    }
}
