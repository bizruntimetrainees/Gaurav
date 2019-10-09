using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    class Usingchecked
    {
        static void Main(string[] args)
        {
            checked
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2);
            }
        }

    }
}
