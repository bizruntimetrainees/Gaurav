using System;
using System.Collections.Generic;
using System.Text;

namespace _06_10_2019
{
    public class Cloths1
    {
        public virtual void sum()
        {
            int a = 10;
            int b = 50;
            Console.WriteLine("sum is:" + (a + b));
        }
        
    }
    public class NextCloths1 : Cloths1
    {
        
        public override void sum()
        {
            int a = 10;
            int b = 50;
            base.sum();
            Console.WriteLine("multiplication is:" + (a * b));
        }

    }
    class CallingMethodByBase
    {
        static void Main(string[] args)
        {
            NextCloths1 n = new NextCloths1();
            n.sum();

        }
    }
}
