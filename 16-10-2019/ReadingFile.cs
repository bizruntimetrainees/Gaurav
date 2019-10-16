using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace _16_10_2019
{
    class ReadingFile
    {
        public static async void CallMethod()
        {
            string path = "D:\\Gaurav\\bizruntime\\List.txt";
            Task<int> task = ReadFile(path);

            Console.WriteLine("Rest work is Runningg..");

            int length = await task;
            Console.WriteLine("Total length:" + length);

            Console.WriteLine("After Rest work Running..");

        }
        public static async Task<int> ReadFile(string file)
        {
            int length = 0;

            Console.WriteLine("File Reading is Continueing.....");

            StreamReader reader = new StreamReader(file);
            
                string s = await reader.ReadToEndAsync();

                length = s.Length;
            string line = reader.ReadLine();
            Console.WriteLine(line);
            
            Console.WriteLine("File Reading is Completed..");
            return length;
        }
        static void Main(string[] args)
        {
            Task task = new Task(CallMethod);
            task.Start();
            task.Wait();
            
        }
    }
}
