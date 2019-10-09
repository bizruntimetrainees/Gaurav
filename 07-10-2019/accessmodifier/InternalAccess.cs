using System;
using System.Collections.Generic;
using System.Text;

namespace _07_10_2019
{
    class InternalTest
    {
        internal string name = "Shubbu kumar";
        internal void show()
        {
            Console.WriteLine("internal modifier used:");
        }
    }
    class InternalAccess
    {
        static void Main(string[] args)
        {
            InternalTest internalTest = new InternalTest();

            Console.WriteLine("Hello " + internalTest.name);
            internalTest.show(); 

            Console.WriteLine("Progran compiled Successfully:");
        }
    }
}
