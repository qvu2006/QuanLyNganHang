using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class GiaoDichDAL
    {
        public DataTable GetAll()
        {
            return HandleDB.GetData("sp_LayGiaoDich");
        }

        public void Insert(GiaoDichDTO gd)
        {
            HandleDB.ExecuteNonQuery("sp_themGiaoDich",
                new SqlParameter("@maGD", gd.MaGiaoDich),
                new SqlParameter("@soTK", gd.SoTaiKhoan),
                new SqlParameter("@soTien", gd.SoTien),
                new SqlParameter("@loai", gd.LoaiGiaoDich)
            );
        }
    }
}