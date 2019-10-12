using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace _12_10_2019
{
    public class UsingSleep
    {
        public static void Thread1()
        {
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(5000);
            }
        }
    }
    class SleepMethodInThread
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(UsingSleep.Thread1));
            Thread thread1 = new Thread(new ThreadStart(UsingSleep.Thread1));
            thread.Start();
            thread1.Start();
        }

    }
}
