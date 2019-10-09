using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace _09_10_2019
{
    class BinaryWriterEx
    {
        static void Main(string[] args)
        {
            string fileName = "D:\\Gaurav\\C#\\binarydata.txt";
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName,FileMode.Create)))
            {
                writer.Write(2.5);
                writer.Write("this is binaywriter class");
                writer.Write(true);

            }
            Console.WriteLine("Data written successfully");
        }
    }
}
