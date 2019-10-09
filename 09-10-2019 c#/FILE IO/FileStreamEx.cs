using System;
using System.IO;

namespace _09_10_2019
{
    class FileStreamEx
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("D:\\Gaurav\\C#\\stream.txt", FileMode.OpenOrCreate);
            f.WriteByte(65);
            f.WriteByte(67);
            f.Close();
            Console.WriteLine("file created");
        }
    }
}
