using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTHDAL;
using QLTHDTO;

namespace QLTHBUS
{
    class QuanLyLopBUS
    {
        private QuanLyLopDAL qllDAL;

        public QuanLyLopBUS()
        {
            qllDAL = new QuanLyLopDAL();
        }

        public bool Them(QuanLyLopDTO QLL)
        {
            bool re = qllDAL.Them(QLL);
            return re;
        }

        public bool Xoa(QuanLyLopDTO QLL)
        {
            bool re = qllDAL.Xoa(QLL);
            return re;
        }
        public bool Sua(QuanLyLopDTO QLL)
        {
            bool re = qllDAL.Sua(QLL);
            return re;
        }

        public List<QuanLyLopDTO> SelectDSLop(string TenLop)
        {
            return qllDAL.SelectDSLop(TenLop);
        }

      
    }
}
