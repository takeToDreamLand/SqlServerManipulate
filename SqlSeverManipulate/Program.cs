using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatasetMultipulat
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConnectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=ConsotoUniversityDatabase;Integrated Security=SSPI";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectionString;
            try
            {
                con.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con != null) con.Close(); // 关闭连接
            }
        }
    }
}
