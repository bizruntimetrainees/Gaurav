using System;
using System.Collections.Generic;
using System.Text;

namespace _11_10_2019
{
    delegate int Calculator(int n);
    class Delegates
    {
         static int number = 100;
        public static int Add(int n)
        {
            number = number + n;
            return number;
        }
        public static int Multi(int n)
        {
            number = number * n;
            return number;
        }
        public static int GetNum()
        {
            return number;
        }
        public static void Main(string[] args)
        {
            Calculator c = new Calculator(Add);
            Calculator c1 = new Calculator(Multi);
            c(20);
            Console.WriteLine("after calling add() number is:" + GetNum());
            c1(3);
            Console.WriteLine("after calling Multi() number is:" + GetNum());
            
        }
    }
}
