using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

namespace _17_10_2019
{
    class AsyncExample
    {
        static int fact = 1;
        public static async void CallMethod()
        {
            Console.WriteLine("enter a Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Task<int> task = PrintNumber(num);
            Console.WriteLine("first it will run..");
            int fact = await task;
            Console.WriteLine("factorial is:"+fact);
        }
        public static async Task<int> PrintNumber(int num)
        {
            for(int i=1;i<=num;i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            Task task = new Task(CallMethod);
            task.Start();
            task.Wait();
            Console.WriteLine("Program is Success....");
        }
    }
}
