using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTHDAL;
using QLTHDTO;

namespace QLTHBUS
{
    public class QuanLyThamSoBUS
    {
        private QuanLyThamSoDAL qltsDAL;
        public QuanLyThamSoBUS()
        {
            qltsDAL = new QuanLyThamSoDAL();
        }

        public bool them(ThamSoDTO TsDTO)
        {
            bool re = qltsDAL.Them(TsDTO);
            return re;
        }

        public bool themlop(ThamSoDTO TsDTO)
        {
            bool re = qltsDAL.ThemLop(TsDTO);
            return re;
        }

        public bool themmonhoc(ThamSoDTO TsDTO)
        {
            bool re = qltsDAL.ThemMonHoc(TsDTO);
            return re;
        }

        public bool sua(ThamSoDTO TsDTO)
        {
            bool re = qltsDAL.Sua(TsDTO);
            return re;
        }

        public bool sualop(ThamSoDTO TsDTO)
        {
            bool re = qltsDAL.SuaLop(TsDTO);
            return re;
        }

        public bool suamonhoc(ThamSoDTO TsDTO)
        {
            bool re = qltsDAL.SuaMonHoc(TsDTO);
            return re;
        }
        public List<ThamSoDTO> SelectAll()
        {
            return qltsDAL.SelectAll();
        }


        public bool xoa(ThamSoDTO TsDTO)
        {
            bool re = qltsDAL.Xoa(TsDTO);
            return re;
        }

        public bool xoalop(ThamSoDTO TsDTO)
        {
            bool re = qltsDAL.XoaLop(TsDTO);
            return re;
        }

        public bool xoamonhoc(ThamSoDTO TsDTO)
        {
            bool re = qltsDAL.XoaMonHoc(TsDTO);
            return re;
        }

    }
}
