using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DatasetMultipulat
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConnectionString = "Data Source=QXAAKHS0MDUJ3QK\\TEW_SQLEXPRESS;Initial Catalog=Test;Integrated Security=True";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectionString;
            SqlCommand cmd = new SqlCommand();
            int i = 90;
            int result;
            string cmdText = "";
            try
            {
                con.Open();
                cmd.CommandTimeout = 15;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                while (i < 1000)
                {
                    cmdText = "USE [Test] " +
                        "INSERT INTO [dbo].[OVEN] " + "([ID] ,[OverTEMP Protection TEMP],[Main heating TEMP],[Currtent Set TEMP],[Currtent Work TEMP],[1st TEMP],[2nd TEMP] ,[3rd TEMP] ,[4th TEMP] ,[5th TEMP] ,[6th TEMP] ,[7th TEMP] ,[8th  TEMP] ,[Total Work TEMP] ,[Cooling TEMP] ,[Warning TEMP]) " +
                        "VALUES " + "( " + i.ToString() + "," + i.ToString() + "," + i.ToString() + "," + i.ToString() + "," + i.ToString() + "," + i.ToString() + "," + i.ToString() + "," + i.ToString() + "," + i.ToString() + "," + i.ToString() + "," + i.ToString() + "," + i.ToString() + "," + i.ToString() + "," + i.ToString() + "," + i.ToString() + "," + i.ToString() + ") ";
                    cmd.CommandText = cmdText;
                    result = cmd.ExecuteNonQuery();
                    Console.WriteLine("写入成功，返回值为{0}",result);
                    i++;
                    Thread.Sleep(1000); //休眠一秒
                }

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
