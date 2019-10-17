using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Text;

namespace _17_10_2019
{
    
        class AsyncExample2
    {
        public  async Task CallMethod1()
        {
            await ProgramRun();
            Console.WriteLine("Time Consuming Process end");
        }

        public  async Task CallMe()
        {
             await CallMethod1();
            Console.WriteLine("Program execution completed");
        }

        public static  Task ProgramRun()
        {
            return Task.Run(() =>
            {
                System.Threading.Thread.Sleep(500);
            });
        }
        static void Main(string[] args)
            {
            AsyncExample2 As = new AsyncExample2();

             As.CallMe();

        }
        }
}
