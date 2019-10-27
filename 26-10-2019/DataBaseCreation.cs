using System;
using System.Data.SqlClient;

namespace ADO.NETProject
{
    class DataBaseCreation
    {
        public static void RetrieveData()
        {
            string source = "Data Source=106.51.126.111;" +
                                "Initial Catalog=gaurav;" +
                                  "User id=sa;" +
                                   "Password=bizruntime@123;";

            SqlConnection con = new SqlConnection(source);
            string query = "create Database gMishra";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Databse Created...");
            }
            catch(SqlException e)
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
            DataBaseCreation.RetrieveData();
            Console.WriteLine("Program Successfully Run..");
        }
    }
}
