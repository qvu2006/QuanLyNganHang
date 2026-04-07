using System;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class GiaoDichBLL
    {
        GiaoDichDAL dal = new GiaoDichDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public void Insert(GiaoDichDTO gd)
        {
            if (string.IsNullOrWhiteSpace(gd.MaGiaoDich))
                throw new Exception("Thiếu mã giao dịch");

            if (gd.SoTien <= 0)
                throw new Exception("Số tiền phải > 0");

            dal.Insert(gd);
        }
    }
}