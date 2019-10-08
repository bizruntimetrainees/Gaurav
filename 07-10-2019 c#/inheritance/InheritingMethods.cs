using System;
using System.Collections.Generic;
using System.Text;

namespace _06_10_2019
{
    public class Base1
    {
        public void animal()
        {
            Console.WriteLine("Animals have four legs:");
        }
    }
        class Derived1 : Base1
        {
            public void man()
            {
                Console.WriteLine("Men have only Two legs:");
            }
        }
    
    class InheritingMethods
    {
        static void Main(string[] args)
        {
            Derived1 d1 = new Derived1();
            d1.animal();
            d1.man();
        }
    }
}
