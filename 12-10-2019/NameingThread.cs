using System;
using System.Collections.Generic;
using System.Threading;

using System.Text;

namespace _12_10_2019
{
    class NameingThread
    {
        static void Main(string[] args)
        {
                      Text t = new Text();
            UsingDataOfThisClass ut = new UsingDataOfThisClass();
            Thread thread = new Thread(new ThreadStart(t.Thread1));
            Thread thread1 = new Thread(new ThreadStart(ut.Thread2));
            thread.Start();
            thread1.Start();

        }

    }
}
