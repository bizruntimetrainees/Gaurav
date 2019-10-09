using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace _09_10_2019
{
    class ReadingData
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("D:\\Gaurav\\C#\\multiplebyte.txt", FileMode.OpenOrCreate);
            int i = 0; 

            while((i=f.ReadByte())!= -1)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("data read successfully");
        }
    }
}
