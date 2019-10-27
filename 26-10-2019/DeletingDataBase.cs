using System;
using System.Data.SqlClient;

namespace ADO.NETProject
{
    class DeletingDataBase
    {
        public static void DeleteDataBase()
        {
            string source = "Data Source=106.51.126.111;" +
                                "Initial Catalog=master;" +
                                  "User id=sa;" +
                                   "Password=bizruntime@123;";

            SqlConnection con = new SqlConnection(source);
            string query = "Drop DATABASE mishra";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Database Deleted Successfully...");
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
            DeletingDataBase.DeleteDataBase();
            Console.WriteLine("Program Successfully Run..");
        }
    }
}
