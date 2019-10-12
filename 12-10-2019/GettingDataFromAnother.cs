using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace _12_10_2019
{
    class GettingDataFromAnother
    {
        static void Main(string[] args)
        {
            CurrentThread c = new CurrentThread();
            Thread t = new Thread(new ThreadStart(c.Thread1));
            Thread t1 = new Thread(new ThreadStart(c.Thread2));
            t.Name = "First Thread";
            t1.Name = "Second Thread";
            t.Start();
            t1.Start();

        }
    }
}
