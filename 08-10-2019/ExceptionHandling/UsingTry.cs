using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    class UsingTry
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y =  0;
            try
            {
                int z = x / y;
            }
            catch(System.Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Exception handled:" );
        }
    }
}
