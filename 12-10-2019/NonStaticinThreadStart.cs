using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace _12_10_2019
{
    public class TestMyThread
    {
        public void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class NonStaticinThreadStart
    {
        static void Main(string[] args)
        {
            TestMyThread tm = new TestMyThread();
         Thread thread = new Thread(new ThreadStart(tm.Thread1));
         Thread thread1 = new Thread(new ThreadStart(tm.Thread1));
            thread.Start();
            thread1.Start();
        }

    }
}
