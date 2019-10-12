using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace _12_10_2019
{
    public class AgainMyThread
    {
        public static void Thread1()
        {
            Console.WriteLine("Thread one");
        }
        public static void Thread2()
        {
            Console.WriteLine("Thread Two");
        }
    }
    class TaskForEachThread
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(AgainMyThread.Thread1));
            Thread thread2 = new Thread(new ThreadStart(AgainMyThread.Thread2));
            thread.Start();
            thread2.Start();
        }
    }
}
