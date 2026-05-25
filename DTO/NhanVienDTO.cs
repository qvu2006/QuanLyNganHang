using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class NhanVienDTO
    {
        public NhanVienDTO(string maNV, string tenNV, string chucVu, string soDienThoai, string maChiNhanh)
        {
            MaNV = maNV;
            TenNV = tenNV;
            ChucVu = chucVu;
            SoDienThoai = soDienThoai;
            MaChiNhanh = maChiNhanh;
        }

        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string ChucVu { get; set; }
        public string SoDienThoai { get; set; }
        public string MaChiNhanh { get; set; }
    }
}