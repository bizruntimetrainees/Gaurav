using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public struct Ranctangle
    {
        int w;
        int h;
        public Ranctangle(int w,int h)
        {
            this.w = w;
            this.h = h;
        }
        public void display()
        {
            Console.WriteLine("Area of Ractangle is:" + (w * h));
        }
    }
    class StructExample
    {
        static void Main(string[] args)
        {
            Ranctangle r = new Ranctangle(15, 30);
            r.display();
        }
    }
}
