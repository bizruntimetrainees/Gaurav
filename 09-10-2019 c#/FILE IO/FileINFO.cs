using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace _09_10_2019
{
    class FileINFO
    {
        static void Main(string[] args)
        {
            string loc = "D:\\Gaurav\\C#\\Filinfo.txt";
            try
            {
                FileInfo file = new FileInfo(loc);
                file.Create();
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
