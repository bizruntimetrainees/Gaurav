using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace _12_10_2019
{
    public class TestSynchronize
    {
        public static void Thread1()
        {
            for(int i = 1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class WithOutSynchronization
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(TestSynchronize.Thread1));
            t.Start();
        }
    }
}
