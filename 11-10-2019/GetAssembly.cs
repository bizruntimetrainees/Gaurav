using System;
using System.Collections.Generic;
using System.Text;

namespace _11_10_2019
{
    class GetAssembly
    {
        static void Main(string[] args)
        {
            Type type = typeof(System.String);
            Console.WriteLine(type.Assembly);

        }

    }
}
