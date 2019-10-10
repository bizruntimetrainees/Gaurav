using System;
using System.Collections.Generic;


namespace _10_10_2019
{
    class CollectionsEx
    {
        static void Main(string[] args)
        {
            List<String> names = new List<String>();
            names.Add("Gaurav");
            names.Add("Raghav");
            names.Add("Jyothi");
            names.Add("Ankit");
            names.Add("Mishra");

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Names stored Successfully.."); ;
        }
    }
}
