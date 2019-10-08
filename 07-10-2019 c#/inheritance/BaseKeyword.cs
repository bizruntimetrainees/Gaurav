using System;
using System.Collections.Generic;
using System.Text;

namespace _06_10_2019
{
    public class Cloths
    {
        public string color = "white";
    }
    public class NextCloths : Cloths
    {
        string color = "yellow";
        public void showcolor()
        {
            Console.WriteLine("color for base clothes is :" + base.color);
            Console.WriteLine("color for derived cloths is:" + color);
        }

    }
    class BaseKeyword
    {
        static void Main(string[] args)
        {
            NextCloths n = new NextCloths();
                n.showcolor();

        }
    }
}
