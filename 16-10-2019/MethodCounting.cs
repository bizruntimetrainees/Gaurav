using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

namespace _16_10_2019
{
    class MethodCounting
    {
        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 1; i <= 50; i++)
                {
                    Console.WriteLine("Method1 is Running..");
                    count++;
                }
            });
            return count;
        }
        public static void Method2()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Method2 is Running...");
            }
        }
        public static void Method3(int count)
        {
            Console.WriteLine("Total count is:" + count);
        }
        public static async void CallMethod()
        {
            Task<int> task = Method1();
            Method2();
            int count = await task;
            Method3(count);
        }
        static void Main(string[] args)
        {
            CallMethod();
            Console.ReadKey();
        }
    }
}
