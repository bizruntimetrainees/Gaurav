using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace _09_10_2019
{
    class BinarReaderEx
    {
       static string filename = "D:\\Gaurav\\C#\\ReadWrite.txt";
        public static void writebinary()
        {
            
            using (BinaryWriter bw = new BinaryWriter(File.Open(filename,FileMode.Create)))
            {
                bw.Write(2.5);
                bw.Write("Hello C#");
                bw.Write(true);
            }

        }
        public static void readbinary()
        {
            
            using (BinaryReader br = new BinaryReader(File.Open(filename, FileMode.Open)))
            {
               Console.WriteLine("Double value:" +br.ReadDouble());
                Console.WriteLine("String value:" +br.ReadString());
                Console.WriteLine("Boolean value:" + br.ReadBoolean());

                
            }
        }
        static void Main(string[] args)
        {
            BinarReaderEx.writebinary();
            BinarReaderEx.readbinary();
            Console.ReadKey();
            Console.WriteLine("Data read successfully:");

        }
    }
}
