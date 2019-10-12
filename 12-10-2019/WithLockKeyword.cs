using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace _12_10_2019
{
    public class TestLock
    {
        public  void Thread1()
        {
            lock (this)
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine();
                Thread.Sleep(100);
                }
        }
    }

    class WithLockKeyword
    {
        static void Main(string[] args)
        {
            TestLock test = new TestLock();
            Thread t = new Thread(new ThreadStart(test.Thread1));
            Thread t1 = new Thread(new ThreadStart(test.Thread1));
            t.Start();
            t1.Start();
        }
    }
}

