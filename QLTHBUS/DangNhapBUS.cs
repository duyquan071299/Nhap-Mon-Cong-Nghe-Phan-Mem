using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTHDAL;
using QLTHDTO;
namespace QLTHBUS
{
    public class DangNhapBUS
    {
        private DangNhapDAL dangnhapDAL;
        public DangNhapBUS()
        {
            dangnhapDAL = new DangNhapDAL();
        }
       
        public bool DangNhap(DangNhapDTO User)
        {
            return dangnhapDAL.DangNhap(User);
        }
    }
}
