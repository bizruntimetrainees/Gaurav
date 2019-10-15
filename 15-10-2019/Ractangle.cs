using System;
using System.Collections.Generic;
using System.Text;

namespace _15_10_2019
{
    public delegate void RectDelegate(double w, double h);

    
   public class Ractangle
    {
        public static void Area(double w, double h)
        {
            Console.WriteLine("Area is:" + (w * h));
        }
        public static void Peremeter(double w, double h)
        {
            Console.WriteLine("Peremeter is:" + 2*(w + h));
        }
        static void Main(string[] args)
        {
            RectDelegate rect = new RectDelegate(Area);
            RectDelegate rect1 = new RectDelegate(Peremeter);
            rect(54.5, 547);
            rect1(100, 254);
        }
    }
}
