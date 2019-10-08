using System;
using System.Collections.Generic;
using System.Text;

namespace _06_10_2019
{
    class Calculation
    {
        public static  int add(int a, int b)
        {
            return a + b;
        }
        public static int add(int a,int b,int c)
        {
            return a + b + c;
        }
    }
    class MothodOverLoading
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First addintion:"+Calculation.add(54,65));
            Console.WriteLine("Second addintion:"+Calculation.add(21, 36,80));
        }
    }
}
