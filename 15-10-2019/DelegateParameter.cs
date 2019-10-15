using System;
using System.Collections.Generic;
using System.Text;

namespace _15_10_2019
{
    public delegate void PDelegate(int value);
    class DelegateParameter
    {
        public static void Print(PDelegate pd,int num)
        {
            pd(num);
        }
        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number is:" + num);
        }
        public static void Money(int num)
        {
            Console.WriteLine("Money is:" + num);
        }
        static void Main(string[] args)
        {
            Print(PrintNumber, 15487);
            Print(Money, 2154780);
        }
    }
}
