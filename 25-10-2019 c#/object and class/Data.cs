using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_and_class
{
    public class Data
    {
        int id;
        string name;

        public void insert(int i, string n)
        {
            id = i;
            name = n;
        }
        public void display()
        {
            Console.WriteLine("id is:" + id);
            Console.WriteLine("name is:" + name);
        }
        class TestData
        {
            static void Main(string[] args)
            {
                Data d = new Data();
                d.id = 04254;
                d.name = "chandrakar";

                d.insert(d.id, d.name);
                d.display();
            }
        }

    }
}
