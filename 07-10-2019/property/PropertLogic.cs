// we can give any additional message also by set accessor using concatination

using System;
using System.Collections.Generic;
using System.Text;

namespace _06_10_2019
{
    public class TestPropery
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value + " how are you";
            }
        }

    }
    public class PropertLogic
    { 
       public static void Main(string[] args)
        {
            TestPropery p = new TestPropery();
            p.Name = "Hello Gaurav Mishra";

            Console.WriteLine("greeting is:" + p.Name+" ");
        }
    }
}
