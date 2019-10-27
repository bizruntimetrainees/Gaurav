using System;
using System.Data.SqlClient;

namespace ProjectSQL
{
    public class CustomerPersistence
    {
        string source;
        SqlConnection con;
        public void Table()
        {
            source = "Data Source=106.51.126.111;" +
                                    "Initial Catalog=gaurav;" +
                                      "User id=sa;" +
                                       "Password=bizruntime@123;";

            con = new SqlConnection(source);
            string query = "create table Customer(ID INT NOT NULL,NAME NVARCHAR(50) NOT NULL,ADDRESS NVARCHAR(50) NOT NULL)";

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
        public void CreateCustomer(Customer cus)
        {
            int ID = cus.ID;
            string NAME = cus.NAME;
            string ADDRESS = cus.ADDRESS;

            source = "Data Source=106.51.126.111;" +
                                    "Initial Catalog=gaurav;" +
                                      "User id=sa;" +
                                       "Password=bizruntime@123;";

            con = new SqlConnection(source);

            string query = "insert into Customer values('"+ID+"','"+NAME+"','"+ADDRESS+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Record inserted Successfully...");
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
        public void Read()
        {
            Console.WriteLine("before Updation..");
            source = "Data Source=106.51.126.111;" +
                                    "Initial Catalog=gaurav;" +
                                      "User id=sa;" +
                                       "Password=bizruntime@123;";

            con = new SqlConnection(source);

            string query = "select * from Customer";

            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(); 
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
                }
                Console.WriteLine("Data Read Successfully...");
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
        public void Update()
        {
            source = "Data Source=106.51.126.111;" +
                                    "Initial Catalog=gaurav;" +
                                      "User id=sa;" +
                                       "Password=bizruntime@123;";

            con = new SqlConnection(source);

            string query = "update Customer set NAME = 'Arun' where ID=3; ";

            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("1 row updated...");
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

            public void Delete()
            {
             source = "Data Source=106.51.126.111;" +
                                    "Initial Catalog=gaurav;" +
                                      "User id=sa;" +
                                       "Password=bizruntime@123;";

            con = new SqlConnection(source);

                string query = "delete Customer where NAME = 'Amit'; ";

                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("1 record deleted...");
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

            public void CreateColumn()
            {
            source = "Data Source=106.51.126.111;" +
                                    "Initial Catalog=gaurav;" +
                                      "User id=sa;" +
                                       "Password=bizruntime@123;";

            con = new SqlConnection(source);

          
                string query = "ALTER TABLE Customer ADD F_Name NVARCHAR(50) ";

                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("1 Column Added...");
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
        public void ReadAgain()
        {
            Console.WriteLine("After Updation..");
            source = "Data Source=106.51.126.111;" +
                                    "Initial Catalog=gaurav;" +
                                      "User id=sa;" +
                                       "Password=bizruntime@123;";

            con = new SqlConnection(source);

            string query = "select * from Customer";

            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
                }
                Console.WriteLine("Data Read Successfully...");
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
    }


}

