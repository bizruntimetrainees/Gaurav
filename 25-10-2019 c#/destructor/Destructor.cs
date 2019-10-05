using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    class Destructor
    {
        public Destructor()
        {
            Console.WriteLine("its a constructor");
        }
        ~Destructor()
        {
            Console.WriteLine("its a destructor");
        }
        static void Main(string[] args)
        {
            Destructor d = new Destructor();
            Destructor d1 = new Destructor();
            Console.ReadLine();
        }
        
    }
    
}
