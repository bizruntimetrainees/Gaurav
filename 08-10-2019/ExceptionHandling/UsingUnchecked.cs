using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    class UsingUnchecked
    {
        static void Main(string[] args)
        {
            unchecked
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2);
            }
        }
    }
}
