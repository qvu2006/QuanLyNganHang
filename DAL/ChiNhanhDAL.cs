using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class ChiNhanhDAL
    {
        public DataTable GetAll()
        {
            return HandleDB.GetData("sp_LayTatCaChiNhanh");
        }

        public void Insert(ChiNhanhDTO cn)
        {
            HandleDB.ExecuteNonQuery("sp_themChiNhanh",
                new SqlParameter("@maChiNhanh", cn.MaChiNhanh),
                new SqlParameter("@tenChiNhanh", cn.TenChiNhanh),
                new SqlParameter("@diaChi", cn.DiaChi),
                new SqlParameter("@soDienThoai", cn.SoDienThoai)
            );
        }

        public void Update(ChiNhanhDTO cn)
        {
            HandleDB.ExecuteNonQuery("sp_capNhatChiNhanh",
                new SqlParameter("@maChiNhanh", cn.MaChiNhanh),
                new SqlParameter("@tenChiNhanh", cn.TenChiNhanh),
                new SqlParameter("@diaChi", cn.DiaChi),
                new SqlParameter("@soDienThoai", cn.SoDienThoai)
            );
        }

        public void Delete(string ma)
        {
            HandleDB.ExecuteNonQuery("sp_xoaChiNhanh",
                new SqlParameter("@maChiNhanh", ma)
            );
        }
    }
} 