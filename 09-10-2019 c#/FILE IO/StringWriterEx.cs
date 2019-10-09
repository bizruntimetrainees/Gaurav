using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace _09_10_2019
{
    class StringWriterEx
    {
        static void Main(string[] args)
        {
            string text = "Hello c# \n" +
                          "This is firt program of Stringwriter\n" +
                          "After writing will read the data:";

            StringBuilder sb = new StringBuilder();
            StringWriter writer = new StringWriter(sb);
            writer.WriteLine(text);
            writer.Flush();

            StringReader reader = new StringReader(sb.ToString());
            while (reader.Peek()>-1)
            {
                Console.WriteLine(reader.ReadLine());
            }

            Console.WriteLine("Data Read Successfully:");
        }

    } 
}
