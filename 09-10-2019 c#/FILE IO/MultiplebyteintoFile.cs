using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace _09_10_2019
{
    class MultiplebyteintoFile
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("D:\\Gaurav\\C#\\multiplebyte.txt", FileMode.OpenOrCreate);
            for (int i = 65; i <= 90; i++)
            {
                f.WriteByte((byte)i);
            }
            f.Close();
            Console.WriteLine("data have been written successfully:");
      }

}
}
