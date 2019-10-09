using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace _09_10_2019
{
    class ReadDatafromFileinfo
    {
        static void Main(String[] args)
        {
            string loc = "D:\\Gaurav\\C#\\Filinfo.txt";
            try
            {
                FileInfo file = new FileInfo(loc);

                StreamReader reader = file.OpenText();

                Console.WriteLine(reader.ReadLine());

                Console.WriteLine("File's data read Successfully..");
            }
            catch (IOException e)
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
