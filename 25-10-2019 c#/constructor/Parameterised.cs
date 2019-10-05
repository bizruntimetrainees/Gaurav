using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Parameterised
    {
        int Fact = 1;
        int number;
        public Parameterised(int number)
        {
            this.number = number;
        }
        public void fact()
        {
            if(number == 0)
            {
                Console.WriteLine("factorial is :" + number);
            }
            for (int i = 1; i <= number; i++)
            {
                Fact = Fact * i;
            }
            Console.WriteLine("factorial is :" + Fact);

        }
        static void Main(string[] args)
        {
            Parameterised p = new Parameterised(5);
        }
    }
}
