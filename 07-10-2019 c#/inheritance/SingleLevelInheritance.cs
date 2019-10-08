using System;
using System.Collections.Generic;
using System.Text;

namespace _06_10_2019
{
    public class Base
    {
        public float salary;
    }
    class Derived : Base
    {
        public int bonus;
    }
    class SingleLevelInheritance
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            d.salary = 40000;
            d.bonus = 10000;
            Console.WriteLine("salary is:" + d.salary);
            Console.WriteLine("Bonus is:" + d.bonus);
            Console.WriteLine("total is:" + (d.salary+d.bonus));
        }
    }
}
