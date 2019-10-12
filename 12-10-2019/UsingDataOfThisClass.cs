using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace _12_10_2019
{
    public class Text
    {
        public void Thread1()
        {
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(3000);
            }
        }
    }
   public class UsingDataOfThisClass
    {
        public void Thread2()
        {
            for(int i =6;i<=10;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(3000);
            }
        }
    }
}
