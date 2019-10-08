using System;
using System.Collections.Generic;
using System.Text;

namespace _07_10_2019
{
    class InternalTest1
    {
        protected internal string name = "Shubbu kumar";
        protected internal void show()
        {
            Console.WriteLine("protected internal modifier used:");
        }
    }
    class ProtectedInternal
    {
        static void Main(string[] args)
        {
            InternalTest1 internalTest = new InternalTest1();

            Console.WriteLine("Hello " + internalTest.name);
            internalTest.show();

            Console.WriteLine("Progran compiled Successfully:");
        }
    }
}
