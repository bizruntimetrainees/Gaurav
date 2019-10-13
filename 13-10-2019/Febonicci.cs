using System;

namespace _13_10_2019
{
    class Febonicci
    {
        static int n1 = 0, n2 = 1,num=0;
        public static void Febo()
        {
            Console.Write(n1 + " "+n2+" ");
            
         
            for(int i=1;i<=10;i++)
            {
                num = n1 + n2;
                Console.Write(num+" ");
                n1 = n2;
                n2 = num;
            }
        }
        static void Main(string[] args)
        {
          
            Febonicci.Febo();

        }
    }
}
