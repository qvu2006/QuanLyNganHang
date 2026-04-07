using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class TaiKhoanDAL
    {
        public DataTable GetAll()
        {
            return HandleDB.GetData("sp_LayTaiKhoan");
        }

        public void Insert(TaiKhoanDTO tk)
        {
            HandleDB.ExecuteNonQuery("sp_themTaiKhoan",
                new SqlParameter("@soTK", tk.SoTaiKhoan),
                new SqlParameter("@maKH", tk.MaKH),
                new SqlParameter("@soDu", tk.SoDu),
                new SqlParameter("@loai", tk.LoaiTaiKhoan)
            );
        }
    }
}