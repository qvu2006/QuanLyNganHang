namespace DTO
{
    public class KhachHangDTO
    {
        public KhachHangDTO(string maKH, string tenKH, string diaChi, string soDienThoai, string maChiNhanh)
        {
            MaKH = maKH;
            TenKH = tenKH;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            MaChiNhanh = maChiNhanh;
        }

        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string MaChiNhanh { get; set; }
    }
}