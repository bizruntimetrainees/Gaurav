using System;
using System.Collections.Generic;
using System.Text;

namespace _06_10_2019
{
    sealed public class Sealed
    {
        public void message()
        {
            Console.WriteLine("Hello bro");
        }
    }
    public class DerivedSealed  //: Sealed (Compile Time Error: 'Dog': cannot derive from sealed type 'Animal')
    {
        public void message()
        {
            Console.WriteLine("bye bro");
        }
    }
    class SealedKeyword
    {
        static void Main(string[] args)
        {
            DerivedSealed ds = new DerivedSealed();
            ds.message();


        }
    }
}
