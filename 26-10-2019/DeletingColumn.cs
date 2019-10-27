using System;
using System.Data.SqlClient;

namespace ADO.NETProject
{
    class DeletingColumn
    {
        public static void DeleteColumn()
        {
            string source = "Data Source=106.51.126.111;" +
                                "Initial Catalog=gaurav;" +
                                  "User id=sa;" +
                                   "Password=bizruntime@123;";

            SqlConnection con = new SqlConnection(source);
            string query = "ALTER TABLE EmpTable DROP COLUMN Salary; ";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("1 Column DELETED...");
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
            DeletingColumn.DeleteColumn();
            Console.WriteLine("Program Successfully Run..");
        }
    }
}
