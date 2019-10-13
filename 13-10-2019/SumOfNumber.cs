using System;
using System.Collections.Generic;
using System.Text;

namespace _13_10_2019
{
    class SumOfNumber
    {
       static int m, sum = 0;
        public static void Sum(int num)
        {
            while (num > 0)
            {
                m = num % 10;
                sum = sum + m;
                num = num / 10;
            }
            Console.WriteLine("Sum is:" + sum);
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            SumOfNumber.Sum(num);
        }
    }
}
