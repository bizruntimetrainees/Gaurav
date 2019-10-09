using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace _09_10_2019
{
    class TextReadingfullLine
    {
        static void Main(string[] args)
        {
            using (TextReader tr = File.OpenText("D:\\Gaurav\\C#\\writefile.txt"))
            {
                string c = "";
                while ((c = tr.ReadLine()) != null)
                {
                    Console.WriteLine(c);
                }
            }
            Console.WriteLine("Data Read Successfully:");
        }
    }
}
