using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTHDAL;
using QLTHDTO;

namespace QLTHBUS
{
    public  class QuanLyDiemBUS
    {
        private QuanLyDiemDAL qldDAL;

        public QuanLyDiemBUS()
        {
            qldDAL = new QuanLyDiemDAL();
        }

        //public bool Them(QuanLyDiemDTO QLD)
        //{
        //    bool re = qldDAL.Them(QLD);
        //    return re;
        //}

        public bool Sua(QuanLyDiemDTO QLD)
        {
            bool re = qldDAL.Sua(QLD);
            return re;
        }

        public bool LamMoi(QuanLyDiemDTO QLD)
        {
            bool re = qldDAL.LamMoi(QLD);
            return re;
        }

        public List<QuanLyDiemDTO> SelectHS(QuanLyDiemDTO QLD)
        {
            return qldDAL.SelectHS(QLD);
        }

        public List<QuanLyDiemDTO> SelectMon()
        {
            return qldDAL.SelectDSMonHoc();
        }
    }
}
