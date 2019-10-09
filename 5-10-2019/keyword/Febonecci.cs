using System;

namespace ThisKeyword
{
    class Febonecci
    {
        int n1 , n2 , num;

        public Febonecci(int n1, int n2,int num)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.num = num;
        }
        public void febo()
        {
            Console.Write(n1 + " "+n2 + " ");

            
            for(int i = 1;i<=10;i++)
            {
                num = n1 + n2;
                Console.Write(num + " ");
                n1 = n2;
                n2 = num;
            }
        }
        static void Main(string[] args)
        {
            Febonecci t = new Febonecci(0, 1, 0);
            t.febo();
        }
    }
}
