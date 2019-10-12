using System;
using System.Threading;

namespace _12_10_2019
{
    class MainThread
    {
        static void Main(string[] args)
        {
            Thread thread = Thread.CurrentThread;
            thread.Name = "Main Thread";
            Console.WriteLine("this thread is :"+thread.Name);
        }
    }
}
