using System;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL dal = new NhanVienDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public void Insert(NhanVienDTO nv)
        {
            if (string.IsNullOrWhiteSpace(nv.MaNV) ||
                string.IsNullOrWhiteSpace(nv.TenNV))
                throw new Exception("Thiếu dữ liệu nhân viên");

            dal.Insert(nv);
        }

        public void Delete(string ma)
        {
            if (string.IsNullOrWhiteSpace(ma))
                throw new Exception("Chưa chọn nhân viên");

            dal.Delete(ma);
        }
    }
}