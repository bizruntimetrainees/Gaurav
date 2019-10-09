using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace _09_10_2019
{
    class DeletingDirectory
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo("D:\\Gaurav\\C#\\Mishra");
            try
            {
               
                    directory.Delete();

                    Console.WriteLine("directory deleted successfully..");
                
            }
            catch (IOException e)
            {
                Console.WriteLine("OOPS something went wrong:" + e);
            }
            finally
            {
                Console.WriteLine("finally block executed:");
            }
        }
    }
}
