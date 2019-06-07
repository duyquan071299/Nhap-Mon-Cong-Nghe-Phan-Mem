using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTHDAL;
using QLTHDTO;
namespace QLTHBUS
{
    public class QuanLyHocSinhBUS
    {
        private QuanLyHocSinhDAL qlhsDAL;

        public QuanLyHocSinhBUS()
        {
            qlhsDAL = new QuanLyHocSinhDAL();
        }

        public bool Them(QuanLyHocSinhDTO QLHS)
        {
            bool re = qlhsDAL.Them(QLHS);
            return re;
        }

        public bool Xoa(QuanLyHocSinhDTO QLHS)
        {
            bool re = qlhsDAL.Xoa(QLHS);
            return re;
        }
        public bool Sua(QuanLyHocSinhDTO QLHS)
        {
            bool re = qlhsDAL.Sua(QLHS);
            return re;
        }

        public List<string> SelectMSSV()
        {
            return qlhsDAL.SelectMSSV();
        }

        public List<QuanLyHocSinhDTO> SelectAll()
        {
            return qlhsDAL.Select();
        }
    }
}
