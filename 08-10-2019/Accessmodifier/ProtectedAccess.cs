using System;
using System.Collections.Generic;
using System.Text;

namespace _07_10_2019
{
    class ProtectdTest
    {
        protected string name = "Shubbu kumar";
        protected void show()
        {
            Console.WriteLine("protected modifier used:");
        }
    }
    class ProtectedAccess
    {
        static void Main(string[] args)
        {
            ProtectdTest p = new ProtectdTest();
            /*
            Console.WriteLine("Hello " + p.name);
            p.show(); */
            // ProtectedTest.name' is inaccessible due to its protection level.

            Console.WriteLine("Progran compiled Successfully:");
        }
    }
}
