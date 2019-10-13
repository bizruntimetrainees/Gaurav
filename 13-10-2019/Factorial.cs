using System;
using System.Collections.Generic;
using System.Text;

namespace _13_10_2019
{
  
    class Factorial
    {
        static int fact = 1;
        public static void Fact(int num)
        {
            for(int i=1;i<=num;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial is:" + fact);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Factorial.Fact(num);
        }
    }
}
