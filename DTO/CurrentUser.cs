using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DTO
{
    public static class CurrentUser
    {
        public static string QuyenHan { get; set; } = "User";
        public static string MaNhanVien { get; set; }
        public static string TenNhanVien { get; set; }
    }
    public static class SQLConn
    {
        public static String StrConn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NganHang;Integrated Security=True;Encrypt=True";
        public static SqlConnection conn = new SqlConnection(StrConn);

    }
}
