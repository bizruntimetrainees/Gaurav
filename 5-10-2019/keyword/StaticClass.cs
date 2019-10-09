using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
   public static class StaticClass
    {
        public static float pi = 3.14f;
        public static int display(int r)
        {
            return ((int)pi*r * r);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("value of the pi:" + pi);
            Console.WriteLine("Area of circle is:" + display(4));
            Console.WriteLine("Program Compiled Successfully...");
        }
    }
}
