using System;
using System.Data.SqlClient;

namespace ADO.NetProject
{
    class TableCreation
    {
        public static void CreateTable()
        {
            string ConString = @"Data Source=106.51.126.111;" +
                                    "Initial Catalog=gaurav;" +
                                    "User id=sa;" +
                                    "Password=bizruntime@123;";
            SqlConnection con = new SqlConnection(ConString);
            string query = "CREATE TABLE Student2(ID INT NOT NULL,NAME VARCHAR(50) NOT NULL,SUBJECT VARCHAR(50) NOT NULL)";

            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table created Successfully...");
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
            TableCreation.CreateTable();
            Console.WriteLine("Program Successfully Run..");
        }
    }
 }

