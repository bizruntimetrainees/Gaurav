using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace _12_10_2019
{

    class CurrentThread
    {
        public void Thread1()
        {
            Thread t = Thread.CurrentThread;

            Console.WriteLine(t.Name + " is running");
        }
        public void Thread2()
        {
            Thread t1 = Thread.CurrentThread;

            Console.WriteLine(t1.Name + " is running");
        }
    }
}
