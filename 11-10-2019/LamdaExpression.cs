using System;
using System.Collections.Generic;
using System.Text;

namespace _11_10_2019
{
    public delegate int Square(int num);
    
    class LamdaExpression
    {
        static void Main(string[] args)
        {
            Square GetSquare = num => num * num;
            int j = GetSquare(5);
            Console.WriteLine("Square is:" + j);
            
        }

    }
}
