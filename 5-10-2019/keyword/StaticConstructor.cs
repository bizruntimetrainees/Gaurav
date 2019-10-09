using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class StaticConstructor
    {
        int id;
        string name;
        public static float interest;

        public StaticConstructor(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        static StaticConstructor()
        {
            interest = 4.5f;
        }
        public void display()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(interest);
        }
        static void Main(string[] args)
        {
            StaticConstructor s = new StaticConstructor(1254, "maya");
            s.display();
        }
    }
}
