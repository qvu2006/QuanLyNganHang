using System;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL dal = new TaiKhoanDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public void Insert(TaiKhoanDTO tk)
        {
            if (string.IsNullOrWhiteSpace(tk.SoTaiKhoan))
                throw new Exception("Thiếu số tài khoản");

            if (tk.SoDu < 0)
                throw new Exception("Số dư không hợp lệ");

            dal.Insert(tk);
        }
    }
}