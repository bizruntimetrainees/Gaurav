using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace _09_10_2019
{
    class DirectoryInfo1
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo("D:\\Gaurav\\C#\\Mishra");
            try
            {
                if(directory.Exists)
                {
                    Console.WriteLine("Directory already exists,please choose another name:");
                    return;
                }
                else
                {
                    directory.Create();
                    
                    Console.WriteLine("directory created successfully..");
                }
            }catch(IOException e)
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
