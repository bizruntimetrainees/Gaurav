using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace _09_10_2019
{
    class TextReaderEx
    {
        static void Main(string[] args)
        {
            using (TextReader tr = File.OpenText("D:\\Gaurav\\C#\\writefile.txt"))
            { 
                    Console.WriteLine(tr.ReadLine());
                
            }
            Console.WriteLine("Data Read Successfully:");
        }
    }
}
