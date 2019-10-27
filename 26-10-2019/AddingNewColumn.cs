using System;
using System.Data.SqlClient;

namespace ADO.NETProject
{
    class AddingNewColumn
    {
        public static void AddColumn()
        {
            string source = "Data Source=106.51.126.111;" +
                                "Initial Catalog=gaurav;" +
                                  "User id=sa;" +
                                   "Password=bizruntime@123;";

            SqlConnection con = new SqlConnection(source);
            string query = "ALTER TABLE EmpTable ADD Salary INT";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Column Added Succesfully...");
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
            AddingNewColumn.AddColumn();
            Console.WriteLine("Program Successfully Run..");
        }
    }
}
