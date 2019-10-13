using System;
using System.Collections.Generic;
using System.Text;

namespace _13_10_2019
{
    class Swapping
    {
        public static void Swap(int a,int b)
        {
            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("After Swapping:" +a+" " +b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  two number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numbers:" + a + " " + b);
            Swapping.Swap(a,b);
        }
    }
}
