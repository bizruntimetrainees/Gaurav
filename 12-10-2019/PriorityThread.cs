using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace _12_10_2019
{
    class PriorityThread
    {
        static void Main(string[] args)
        {
            Priority1 p = new Priority1();
            Thread t1 = new Thread(new ThreadStart(p.Thread1));
            Thread t2 = new Thread(new ThreadStart(p.Thread1));
            Thread t3 = new Thread(new ThreadStart(p.Thread2));
            Thread t4 = new Thread(new ThreadStart(p.Thread2));
            t1.Name = "First Thread";
            t2.Name = "Second Thread";
            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Normal;
            t3.Priority = ThreadPriority.AboveNormal;
            t4.Priority = ThreadPriority.Highest;
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
        }
    }
}
