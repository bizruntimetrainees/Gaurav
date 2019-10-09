using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace _09_10_2019
{
    class StringReaderEx
    {
        static void Main(string[] args)
        {
            StringWriter writer = new StringWriter();
            writer.Write("Hi,\n sir\n today i m not feeling well.\n so kindly approve my leave for 1 day.\n Thanku ");
            writer.Close();
            Console.WriteLine("File has been created:\n  Below your file's Data\n please check...");
            StringReader reader = new StringReader(writer.ToString());
            while(reader.Peek() > -1)
            {
                Console.WriteLine(reader.ReadLine());
            }
            
        }
    }
}
