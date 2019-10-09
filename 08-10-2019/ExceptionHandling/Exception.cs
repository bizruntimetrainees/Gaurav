using System;

namespace ExceptionHandling
{
    class Exception
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = x / 0;

            Console.WriteLine("value of y:"+y);
        }
    }
}
