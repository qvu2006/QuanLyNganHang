using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class TaiKhoanDTO
    {
        public TaiKhoanDTO(string soTaiKhoan, string maKH, decimal soDu, string loaiTaiKhoan)
        {
            SoTaiKhoan = soTaiKhoan;
            MaKH = maKH;
            SoDu = soDu;
            LoaiTaiKhoan = loaiTaiKhoan;
        }

        public string SoTaiKhoan { get; set; }
        public string MaKH { get; set; }
        public decimal SoDu { get; set; }
        public string LoaiTaiKhoan { get; set; }
    }
}