using System;
using System.Data.SqlClient;

namespace ADO.NETProject
{
    class RenameDataBase
    {
        public static void RenameData()
        {
            string source = "Data Source=106.51.126.111;" +
                                "Initial Catalog=master;" +
                                  "User id=sa;" +
                                   "Password=bizruntime@123;";

            SqlConnection con = new SqlConnection(source);
            string query = "ALTER DATABASE gMishra MODIFY NAME = mishra";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Database Renamed Successfully...");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Exception Details:" + e.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        static void Main(string[] args)
        {
            RenameDataBase.RenameData();
            Console.WriteLine("Program Successfully Run..");
        }
    }
}
