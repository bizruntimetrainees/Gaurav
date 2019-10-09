using System;
using System.Collections.Generic;
using System.Text;

namespace ThisKeyword
{
    class PrimeNumber
    {
         int flag, num,num1;
        public PrimeNumber(int num,int flag,int num1)
        {
            this.num = num;
            this.flag = flag;
            this.num1 = num1;
        }
        public void Result()
        {
            num1 = num / 2;
            if(num==0 || num == 1)
            {
                Console.WriteLine("Not a Prime Number");
            }

            for(int i = 2; i<=num1;i++)
            {
                if(num % i ==0)
                {
                    Console.WriteLine("Not a Prime number");
                    flag = 1;
                    break;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine("Prime number");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to check Prime");
            int i = Convert.ToInt32(Console.ReadLine());
            PrimeNumber p = new PrimeNumber(i, 0, 0);
            p.Result();
        }
    }
}
