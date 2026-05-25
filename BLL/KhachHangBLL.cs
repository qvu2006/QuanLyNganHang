using System;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class KhachHangBLL
    {
        KhachHangDAL dal = new KhachHangDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public void Insert(KhachHangDTO kh)
        {
            if (string.IsNullOrWhiteSpace(kh.MaKH) ||
                string.IsNullOrWhiteSpace(kh.TenKH))
                throw new Exception("Thiếu dữ liệu khách hàng");

            dal.Insert(kh);
        }

        public void Delete(string ma)
        {
            if (string.IsNullOrWhiteSpace(ma))
                throw new Exception("Chưa chọn khách hàng");

            dal.Delete(ma);
        }
    }
}