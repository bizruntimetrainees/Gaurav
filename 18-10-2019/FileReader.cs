using System;
using System.IO;

namespace _18_10_2019
{
    class FileReader
    {
        public static void ReadingFile()
        {
            string path = "D:\\Gaurav\\bizruntime\\List.txt";
             if(!File.Exists(path))
            {
                StreamWriter sw = File.CreateText(path);
                sw.Write("hello");
                sw.Write("good");
                sw.Write("Morining");
            }
            StreamReader sr = File.OpenText(path);
            string s;
            while((s=sr.ReadLine())!=null)
            {
                Console.WriteLine(s);
            }
        }
        static void Main(string[] args)
        {
            FileReader.ReadingFile();

            Console.WriteLine("file reading successfully com[pleted...");
        }
    }
}
