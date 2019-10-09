using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace _09_10_2019
{
    class TextWriterEx
    {
        static void Main(string[] args)
        {
            using (TextWriter writer = File.CreateText("D:\\Gaurav\\C#\\writefile.txt")) 
            {
                writer.WriteLine("Hello c#");
                writer.WriteLine("This is File Handling:");

            }
            Console.WriteLine("Data written successfully:");
        }
    }
}
