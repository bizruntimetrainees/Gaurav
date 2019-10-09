using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace _09_10_2019
{
    class StreamReader1
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("D:\\Gaurav\\C#\\StreamWrite.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(f);
            
            string s = sr.ReadLine();
            Console.WriteLine(s);
            sr.Close();
            f.Close();
            Console.WriteLine("Read Data successfuly:");
        }
    }
}
