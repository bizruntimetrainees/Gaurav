using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Text;

namespace _12_10_2019
{
    public class MyThread 
    {
        public static void Thread1()
        {
            for(int i = 0;i<=10;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class ThreadStart1
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(MyThread.Thread1));
            Thread thread1 = new Thread(new ThreadStart(MyThread.Thread1));
            thread.Start();
            thread1.Start();
        }

    }
}
