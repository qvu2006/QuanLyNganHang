using System;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class ChiNhanhBLL
    {
        ChiNhanhDAL dal = new ChiNhanhDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public void Insert(ChiNhanhDTO cn)
        {
            if (string.IsNullOrWhiteSpace(cn.MaChiNhanh) ||
                string.IsNullOrWhiteSpace(cn.TenChiNhanh))
                throw new Exception("Dữ liệu không hợp lệ");

            dal.Insert(cn);
        }

        public void Update(ChiNhanhDTO cn)
        {
            if (string.IsNullOrWhiteSpace(cn.MaChiNhanh))
                throw new Exception("Chưa chọn chi nhánh");

            dal.Update(cn);
        }

        public void Delete(string ma)
        {
            if (string.IsNullOrWhiteSpace(ma))
                throw new Exception("Chưa chọn mã");

            dal.Delete(ma);
        }
    }
}