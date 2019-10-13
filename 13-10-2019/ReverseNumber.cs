using System;
using System.Collections.Generic;
using System.Text;

namespace _13_10_2019
{
    class ReverseNumber
    {
        static int r, sum = 0, temp;
        public static void Reverse(int num)
        {
            temp = num;
            while (num > 0)
            {
                r = num % 10;
                sum = (sum * 10) + r;
                num = num / 10;
            }
            Console.WriteLine("Reverse is:" + sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            ReverseNumber.Reverse(num);
        }
    }
}
