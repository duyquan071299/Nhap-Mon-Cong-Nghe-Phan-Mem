using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHDTO
{
    public class QuanLyHocSinhDTO
    {
        private string sMaHS;
        private string sKhoi;
        private string sHoTen;
        private string sGioiTinh;
        private DateTime dtNgaySinh;
        private string sNoiSinh;
        private string sNguyenQuan;
        private string sDanToc;
        private string sTonGiao;
        private string sHoKhauTT;
        private string sTenCha;
        private string sNNCha;
        private string sTenMe;
        private string sNNMe;
        private string sUuTien;


        public string MaHS { get => sMaHS; set => sMaHS = value; }
        public string Khoi { get => sKhoi; set => sKhoi = value; }
        public string HoTen { get => sHoTen; set => sHoTen = value; }
        public string GioiTinh { get => sGioiTinh; set => sGioiTinh = value; }
        public DateTime NgaySinh { get => dtNgaySinh; set => dtNgaySinh = value; }
        public string NoiSinh { get => sNoiSinh; set => sNoiSinh = value; }
        public string NguyenQuan { get => sNguyenQuan; set => sNguyenQuan = value; }
        public string DanToc { get => sDanToc; set => sDanToc = value; }
        public string TonGiao { get => sTonGiao; set => sTonGiao = value; }
        public string HoKhauTT { get => sHoKhauTT; set => sHoKhauTT = value; }
        public string TenCha { get => sTenCha; set => sTenCha = value; }
        public string NNCha { get => sNNCha; set => sNNCha = value; }
        public string TenMe { get => sTenMe; set => sTenMe = value; }
        public string NNMe { get => sNNMe; set => sNNMe = value; }
        public string UuTien { get => sUuTien; set => sUuTien = value; }
    }
}
