using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace _09_10_2019
{
    class StreamWrtier
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("D:\\Gaurav\\C#\\StreamWrite.txt", FileMode.OpenOrCreate);
            StreamWriter s = new StreamWriter(f);

            s.WriteLine("WelCome to C# world:");
            s.WriteLine("Hello Gaurav Mishra");
            s.Close();
            f.Close();
        }
    }
}
