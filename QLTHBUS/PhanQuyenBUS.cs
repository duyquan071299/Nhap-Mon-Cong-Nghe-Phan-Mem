using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTHDAL;
using QLTHDTO;

namespace QLTHBUS
{
    public class PhanQuyenBUS
    {

        private PhanQuyenDAL phanquyenDAL;
        public PhanQuyenBUS()
        {
            phanquyenDAL= new PhanQuyenDAL();
        }

        public List<string> TimNguoiDung(string TenUser)
        {
            return phanquyenDAL.TimNguoiDung(TenUser);
        }


        public string getMaUser(string TenUser)
        {
            return phanquyenDAL.getMaUser(TenUser);
        }

        public string getMaQuyen(string TenQuyen)
        {
            return phanquyenDAL.getMaQuyen(TenQuyen);
        }

        public bool ChinhSuaQuyen(string MaUser, string MaQuyen, bool Order)
        {
            return phanquyenDAL.ChinhSuaQuyen(MaUser, MaQuyen, Order);
        }
    }
}
