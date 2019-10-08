using System;
using System.Collections.Generic;
using System.Text;

namespace _06_10_2019
{
    class Calculation1
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static float add(float a, float b)
        {
            return a + b ;
        }
    }
        class ChangingDataType
    {
            static void Main(string[] args)
            {
                Console.WriteLine("First addintion:" + Calculation1.add(54, 65));
                Console.WriteLine("Second addintion:" + Calculation1.add(21.3f, 36.54f));
            }
        }
}
