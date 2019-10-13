using System;
using System.Collections.Generic;
using System.Text;

namespace _13_10_2019
{
    class ArmstrongNumber
    {
        static int r, sum = 0,temp;
        public static void Armstrong(int num)
        {
            temp = num;
            while(num>0)
            {
                r = num % 10;
                sum = sum + (r * r * r);
                num = num / 10;
            }
            if(temp == sum)
            {
                Console.WriteLine("Number is Armstrong number");
            }
            else
            {
                Console.WriteLine("Number is not Armstrong Number:");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            ArmstrongNumber.Armstrong(num);
        }
    }
}
