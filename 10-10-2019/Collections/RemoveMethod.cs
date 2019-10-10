using System;
using System.Collections.Generic;
using System.Text;

namespace _10_10_2019
{
    class RemoveMethod
    {
        static void Main(string[] args)
        {
            // USING COLLECTION INITIALIZER
            List<String> list = new List<String>() { "JAVA", "C#", "PYTHON", "PHP", "C++", "JAVASCRIPT" };
            
            foreach (var name in list)
            {
                Console.WriteLine(name);
            }
            list.Remove("JAVA");
            Console.WriteLine("After removing..");
            foreach (var name in list)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Value stored successfully..");

        }
    }
}
