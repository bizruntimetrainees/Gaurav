using System;
using System.Collections.Generic;
using System.Text;

namespace _07_10_2019
{
    class PrivateAccess
    {
        private string name = "Shubbu kumar";
        private void show()
        {
            Console.WriteLine("private modifier used:");
        }

        static void Main(string[] args)
        {
            PrivateAccess p = new PrivateAccess();

            Console.WriteLine("Hello " + p.name);
            p.show();

            Console.WriteLine("Progran compiled Successfully:");
        }
    }
}
