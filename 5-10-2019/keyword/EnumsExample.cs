using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class EnumsExample
    {
        public enum Season {winter,summer,spring,rainy,fall};

        static void Main(string[] args)
        {
            int x = (int)Season.summer;
            int y = (int)Season.fall;

            Console.WriteLine("index of summer:" + x);
            Console.WriteLine("index of fall:" + y);
        }
    }
}
