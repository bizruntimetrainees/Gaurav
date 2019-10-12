using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace _12_10_2019
{
    public class  UsingJoin
    {
        public static void Thread1()
        {
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(3000);
            }
        }
    }

    class JoinMethod
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(UsingJoin.Thread1));
            Thread thread1 = new Thread(new ThreadStart(UsingJoin.Thread1));
            thread.Start();
            thread.Join();
            thread1.Start();
            thread1.Join();

            Console.WriteLine("end of the main...");


        }
    }
}
