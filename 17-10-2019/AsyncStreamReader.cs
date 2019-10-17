using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

using System.Text;

namespace _09_10_2019
{
    class AsyncStreamReader
    {
        public static async void Method1()
        {
            string fileName = "D:\\Gaurav\\bizruntime\\List.txt";

            Task<string> task = ReadFile(fileName);
            Console.WriteLine("this task is running");

            string line = await task;
            Console.WriteLine(line);

            
        }
        public static async Task<string> ReadFile(string file)
        {
            StreamReader reader = new StreamReader(file);
      
                    string line = reader.ReadLine();
               
            
            return line;
        }
            static void Main(string[] args)
        {
            Task task = new Task(Method1);
            task.Start();
            task.Wait();
            
            Console.WriteLine("Data written successfully");
        }
    }
}
