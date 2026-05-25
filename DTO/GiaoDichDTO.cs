using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class GiaoDichDTO
    {
        public GiaoDichDTO(string maGiaoDich, string soTaiKhoan, decimal soTien, string loaiGiaoDich, DateTime ngayGiaoDich)
        {
            MaGiaoDich = maGiaoDich;
            SoTaiKhoan = soTaiKhoan;
            SoTien = soTien;
            LoaiGiaoDich = loaiGiaoDich;
            NgayGiaoDich = ngayGiaoDich;
        }

        public string MaGiaoDich { get; set; }
        public string SoTaiKhoan { get; set; }
        public decimal SoTien { get; set; }
        public string LoaiGiaoDich { get; set; }
        public DateTime NgayGiaoDich { get; set; }
    }
}