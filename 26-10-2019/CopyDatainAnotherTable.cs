using System;
using System.Data.SqlClient;

namespace ADO.NETProject
{
    class CopyDatainAnotherTable
    {
        public static void CopyData()
        {
            string source = @"Data Source=106.51.126.111;" +
                                   "Initial Catalog=gaurav;" +
                                   "User id=sa;" +
                                   "Password=bizruntime@123;";

            SqlConnection con = new SqlConnection(source);
            string query = "INSERT INTO Student2(ID,NAME,SUBJECT) SELECT ID,NAME,SUBJECT FROM Student";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Data copied Successfully...");
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
            CopyDatainAnotherTable.CopyData();
            Console.WriteLine("Program Successfully Run..");
        }
    }
}
