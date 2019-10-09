using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace _09_10_2019
{
    class ReadingMultiline
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("D:\\Gaurav\\C#\\StreamWrite.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(f);
            string c = "";
            while((c=sr.ReadLine())!=null)
            {
                Console.WriteLine(c);
            }
            
            sr.Close();
            f.Close();
            Console.WriteLine("Read Data successfuly:");
        }
    }
}
