using System;
using System.Data.SqlClient;

namespace ADO.NetProject
{
    class TableData
    {
        static void Main(string[] args)
        {
            string ConString = @"Data Source=106.51.126.111;" +
                                "Initial Catalog=gaurav;" +
                                "User id=sa;" +
                                "Password=bizruntime@123;";
            SqlConnection con = new SqlConnection(ConString);
            string query = "Select * from Student";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString()+" "+reader[2].ToString());
            }
            con.Close();
        }
    }
}
