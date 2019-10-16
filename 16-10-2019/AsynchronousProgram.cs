using System;
using System.Threading.Tasks;

namespace _16_10_2019
{
    class AsynchronousProgram
    {
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine("Method1 is Running..");
                }
            });
        }
        public static void Method2()
        {
            for(int i=1;i<=20;i++)
            {
                Console.WriteLine("Method2 is Running...");
            }
        }
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Console.ReadKey();
        }
    }
}
