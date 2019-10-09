using System;
using System.Collections.Generic;
using System.Text;

namespace _07_10_2019
{
    class PublicTest
    {
        public string name = "Shubbu kumar";
        public void show()
        {
            Console.WriteLine("public modifier used:");
        }
    }
    class AccessModifier
    {
        static void Main(string[] args)
        {
            PublicTest p = new PublicTest();
            Console.WriteLine("Hello " + p.name);
            p.show();
            Console.WriteLine("Progran compiled Successfully:");
        }
    }
}
