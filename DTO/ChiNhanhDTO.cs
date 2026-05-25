using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ChiNhanhDTO
    {
        public ChiNhanhDTO(string maChiNhanh, string tenChiNhanh, string diaChi, string soDienThoai)
        {
            MaChiNhanh = maChiNhanh;
            TenChiNhanh = tenChiNhanh;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
        }

        public string MaChiNhanh { get; set; }
        public string TenChiNhanh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
    }
}
