using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    class SystemException
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[5];
                arr[10] = 50;
            }
            catch (System.SystemException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
