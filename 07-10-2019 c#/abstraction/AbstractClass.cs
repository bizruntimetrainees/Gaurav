using System;
using System.Collections.Generic;
using System.Text;

namespace _06_10_2019
{
    public abstract class Shape
    {
        public abstract void draw();
    }
    public class Ractangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing ractangle:");
        }
    }
    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing circle:");
        }
    }
    class AbstractClass
    {
        static void Main(string[] args)
        {
            Shape s = new Ractangle();
            Shape s1 = new Circle();
            s.draw();
            s1.draw();
        }



    }
}
