using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class KhachHangDAL
    {
        public DataTable GetAll()
        {
            return HandleDB.GetData("sp_LayKhachHang");
        }

        public void Insert(KhachHangDTO kh)
        {
            HandleDB.ExecuteNonQuery("sp_themKhachHang",
                new SqlParameter("@maKH", kh.MaKH),
                new SqlParameter("@tenKH", kh.TenKH),
                new SqlParameter("@diaChi", kh.DiaChi),
                new SqlParameter("@soDienThoai", kh.SoDienThoai),
                new SqlParameter("@maChiNhanh", kh.MaChiNhanh)
            );
        }

        public void Delete(string ma)
        {
            HandleDB.ExecuteNonQuery("sp_xoaKhachHang",
                new SqlParameter("@maKH", ma)
            );
        }
    }
}