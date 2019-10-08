using System;
using System.Collections.Generic;
using System.Text;

namespace _07_10_2019
{
    class ProtectdTest1
    {
        protected string name = "Shubbu kumar";
        protected void show()
        {
            Console.WriteLine("protected modifier used:");
        }
    }
    class UsingProtectedByInheritance : ProtectdTest1
    {
        static void Main(string[] args)
        {
            UsingProtectedByInheritance p = new UsingProtectedByInheritance();
            
            Console.WriteLine("Hello " + p.name);
            p.show(); 
            
            Console.WriteLine("Progran compiled Successfully:");
        }
    }
}
