using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class HandleDB
    {
        static string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NganHang;Integrated Security=True;Encrypt=True";

        public static DataTable GetData(string sp)
        {
            using (SqlConnection conn = new SqlConnection(HandleDB.conn))
            {
                SqlDataAdapter da = new SqlDataAdapter(sp, conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void ExecuteNonQuery(string sp, params SqlParameter[] param)
        {
            using (SqlConnection conn = new SqlConnection(HandleDB.conn))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sp, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (param != null)
                    cmd.Parameters.AddRange(param);

                cmd.ExecuteNonQuery();
            }
        }
    }
}