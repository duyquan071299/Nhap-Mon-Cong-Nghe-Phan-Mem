using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTHDAL;
using QLTHDTO;

namespace QLTHBUS
{
    class QuanLyDiemBUS
    {
        private QuanLyDiemDAL qldDAL;

        public QuanLyDiemBUS()
        {
            qldDAL = new QuanLyDiemDAL();
        }

        public bool Them(QuanLyDiemDTO QLD)
        {
            bool re = qldDAL.Them(QLD);
            return re;
        }

        public bool Sua(QuanLyDiemDTO QLD)
        {
            bool re = qldDAL.Them(QLD);
            return re;
        }

        public List<QuanLyDiemDTO> SelectHS(string TenLop)
        {
            return qldDAL.SelectHS(TenLop);
        }


    }
}
