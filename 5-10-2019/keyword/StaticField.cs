using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class StaticField
    {
        int id;
        string name;
         static float interest = 8.8f;

        public StaticField(int id,string name)
        {
            this.id = id;
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(interest);
        }
        static void main(string[] args)
        {
            StaticField s = new StaticField(1245, "ramesh");
            s.display();
        }

        
    }
}
