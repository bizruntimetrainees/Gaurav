using System;
using System.Collections.Generic;
using System.Text;

namespace _10_10_2019
{
    class CollectionInitializer
    {
        static void Main(string[] args)
        {
            // USING COLLECTION INITIALIZER
            var list = new List<String>(){ "JAVA", "C#", "PYTHON", "PHP", "C++", "JAVASCRIPT" };

            foreach(var name in list)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Value stored successfully..");

        }
    }
}
