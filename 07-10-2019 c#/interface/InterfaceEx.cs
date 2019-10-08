using System;
using System.Collections.Generic;
using System.Text;

namespace _06_10_2019
{
    public interface Drawable
    {
        void draw();

    }
    public class Ractangle1 : Drawable
    {
        public  void draw()
        {
            Console.WriteLine("drawing Ractangle:");
        }
    }
    public class Circle1 : Drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing Circle:");
        }
    }
    class InterfaceEx
    {
        static void Main(string[] args)
        {
            Drawable d = new Ractangle1();
            d.draw();
            d = new Circle1();
            d.draw();
        }
    }
}
