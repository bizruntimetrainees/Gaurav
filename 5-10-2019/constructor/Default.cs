using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Default
    {
        Default()
        {
            Console.WriteLine("This is default constructor");
        }
        static void Main(string[] args)
        {
            Default d = new Default();
             
        }
    }
}
