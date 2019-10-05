using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class CountObjects
    {
        int id;
        string name;
        static float salary = 54214.55f;
        public static int count = 0;

        public CountObjects(int id,string name)
        {
            this.id = id;
            this.name = name;
            count++;
        }
        public void display()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(salary);
        }
        static void Main(string[] args)
        {
            CountObjects c = new CountObjects(2547, "Hello");
            CountObjects c1 = new CountObjects(2547, "Hello");
            CountObjects c2 = new CountObjects(2547, "Hello");
            c.display();
            Console.WriteLine("Number of Objects is:" +count);
        }

    }
}
