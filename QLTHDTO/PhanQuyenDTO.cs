﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHDTO
{
    public class PhanQuyenDTO
    {
        private string sTenDangNhap;
        private string sQuyen;


        public string TenDangNhap { get => sTenDangNhap; set => sTenDangNhap = value; }
        public string Quyen { get => sQuyen; set => sQuyen = value; }
    }
}
