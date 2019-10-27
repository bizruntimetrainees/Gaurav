using System;
using System.Data.SqlClient;

namespace ADO.NETProject
{
    class ParameterizedQuery
    {
        public static void PassingParametere()
        {
            string source = "Data Source=106.51.126.111;" +
                                "Initial Catalog=gaurav;" +
                                  "User id=sa;" +
                                   "Password=bizruntime@123;";

            SqlConnection con = new SqlConnection(source);
            string query = "insert into Student values(@ID,@NAME,@SUBJECT)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@ID", "4");
            cmd.Parameters.AddWithValue("@NAME", "RAGHVENDRA");
            cmd.Parameters.AddWithValue("@SUBJECT", "DBMS");
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
            ParameterizedQuery.PassingParametere();
            Console.WriteLine("Program Successfully Run..");
        }
    }
}
