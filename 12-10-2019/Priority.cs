using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace _12_10_2019
{
    public class Priority1
    {
        public void Thread1()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name + " is Running ");
            Thread.Sleep(3000);
         }
        public void Thread2()
        {
            for(int i=1;i<=3;i++)
            {
                for(int j=1;j<=i+1;j++)
                {
                    Console.Write("* ");
                    Thread.Sleep(3000);
                }
                Console.WriteLine();
            }
        }
    }
}
