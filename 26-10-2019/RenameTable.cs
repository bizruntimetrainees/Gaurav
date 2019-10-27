using System;
using System.Data.SqlClient;

namespace ADO.NETProject
{
    class RenameTable
    {
        public static void TableRename()
        {
            string source = "Data Source=106.51.126.111;" +
                                "Initial Catalog=gaurav;" +
                                  "User id=sa;" +
                                   "Password=bizruntime@123;";

            SqlConnection con = new SqlConnection(source);
            string query = "EXEC sp_rename 'Employee', 'EmpTable'";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Renamed Successfully...");
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
            RenameTable.TableRename();
            Console.WriteLine("Program Successfully Run..");
        }
    }
}
