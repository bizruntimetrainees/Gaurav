using System;
using System.Collections.Generic;
using System.Text;

namespace _15_10_2019
{
    public delegate void MultiCast(int value);
    class MultiCastDelegate
    {
        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number is :" + num);
        }
        public static void GetMoney(int money)
        {
            Console.WriteLine("Money is :" + money);
        }
        public static void Binary(int bin)
        {
            Console.WriteLine("Value is :" + bin);
        }
        static void Main(string[] args)
        {
            MultiCast multi = PrintNumber;
            multi += GetMoney;
            multi += Binary;
            multi(1200);

            multi -= Binary;
            multi(10000);
        }
    }
}
