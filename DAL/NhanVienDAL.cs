using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class NhanVienDAL
    {
        public DataTable GetAll()
        {
            return HandleDB.GetData("sp_LayNhanVien");
        }

        public void Insert(NhanVienDTO nv)
        {
            HandleDB.ExecuteNonQuery("sp_themNhanVien",
                new SqlParameter("@maNV", nv.MaNV),
                new SqlParameter("@tenNV", nv.TenNV),
                new SqlParameter("@chucVu", nv.ChucVu),
                new SqlParameter("@soDienThoai", nv.SoDienThoai),
                new SqlParameter("@maChiNhanh", nv.MaChiNhanh)
            );
        }

        public void Delete(string ma)
        {
            HandleDB.ExecuteNonQuery("sp_xoaNhanVien",
                new SqlParameter("@maNV", ma)
            );
        }
    }
}