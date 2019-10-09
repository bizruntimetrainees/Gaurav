using System;
using System.Collections.Generic;
using System.Text;

namespace _06_10_2019
{
    public class Animal
    {
        public virtual void dog()
        {
            Console.WriteLine("Now dog is Eating:");

        }
    }
    class Dog : Animal
    {
        public override void dog()
        {
            Console.WriteLine("Afer eating now dog is sleeping:");
        }
    }
    class MothodOverride
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
                d.dog();
        }
    }
}
