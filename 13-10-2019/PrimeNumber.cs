using System;
using System.Collections.Generic;
using System.Text;

namespace _13_10_2019
{
    class PrimeNumber
    {
        static int flag = 0;
        public static void Prime(int num)
        {
            if(num==0 || num==1)
            {
                Console.WriteLine("Number is Not Prime:");
            }
            int m = num / 2;
            for(int i=2;i<=m;i++)
            {
                if(num%i == 0)
                {
                    Console.WriteLine("number is  not prime:");
                    flag = 1;
                }
            }
            if(flag==0)
            {
                Console.WriteLine("Number is Prime:");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            PrimeNumber.Prime(num);

        }
    }
}
