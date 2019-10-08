using System;
using System.Collections.Generic;
using System.Text;

namespace _06_10_2019
{
    public class Base2
    {
        public void india()
        {
            Console.WriteLine("In india have a TajMahal as wonder:");
        }
    }
    class Derived2 : Base2
    {
        public void chaina()
        {
            Console.WriteLine("Chaina have a The Great Wall as  a wonder:");
        }
    }
    class ChildDerived : Derived2
    {
        public void paris()
        {
            Console.WriteLine("In paris there is a Ifill tower:");
        }
    }
    class MultilevelInheritance
    {
        static void Main(string[] args)
        {
            ChildDerived c = new ChildDerived();
                c.india();
            c.chaina();
            c.paris();

        }
    }
}
