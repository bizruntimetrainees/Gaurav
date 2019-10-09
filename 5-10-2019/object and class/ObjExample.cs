using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_and_class
{
    class ObjExample
    {
        int a;
        string name;
        static void Main(string[] args)
        {
            ObjExample obj = new ObjExample();
            obj.a = 10;
            obj.name = "rohit";

            Console.WriteLine(obj.a);
            Console.WriteLine(obj.name);
        }
    }
}
