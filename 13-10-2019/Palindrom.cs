using System;
using System.Collections.Generic;
using System.Text;

namespace _13_10_2019
{
    class Palindrom
    {
        static int r, sum = 0, temp;
        public static void Palin(int num)
        {
            temp = num;
            while(num>0)
            {
                r = num % 10;
                sum = (sum * 10) + r;
                num = num / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("Number is Palindrom");
            }
            else
            {
                Console.WriteLine("Number is Not palindrom");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            Palindrom.Palin(num);
        }
    }
}
