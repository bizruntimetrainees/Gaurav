using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace _09_10_2019
{
    class WritingintoFile
    {
        static void Main(String[] args)
         {
            string loc = "D:\\Gaurav\\C#\\Filinfo.txt";
            try
            {
                FileInfo file = new FileInfo(loc);
            StreamWriter st = file.CreateText();
                st.Write("This file created by Streamwriter:");
                st.Close();
               Console.WriteLine("File created Successfully..");
            }catch(IOException e)
            {
                Console.WriteLine("OOPS somthing went wrong.." + e);
            }
            finally
            {
                Console.WriteLine("Finally block executed:");
            }
          }
    }
}
