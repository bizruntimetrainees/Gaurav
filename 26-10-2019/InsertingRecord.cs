using System;
using System.Data.SqlClient;

namespace ADO.NETProject
{
    class InsertingRecord
    {
        public static void RecordInsert()
        {
            string source = "Data Source=106.51.126.111;" +
                                "Initial Catalog=gaurav;" +
                                  "User id=sa;" +
                                   "Password=bizruntime@123;";

            SqlConnection con = new SqlConnection(source);
            string query = "insert into EmpTable values(1,'GauravMishra', 'Bangalore')";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("1 record inserted...");
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
            InsertingRecord.RecordInsert();
            Console.WriteLine("Program Successfully Run..");
        }
    }
}
