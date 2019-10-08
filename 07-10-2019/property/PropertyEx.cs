using System;

namespace _06_10_2019
{
    public class TestProperty
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
                name = value;
            }
        }
    }
      class PropertyEx
    { 
        static void Main(string[] args)
        {
            TestProperty p = new TestProperty();
            p.Name = "Hello Gaurav Mishra";

            Console.WriteLine("greeting is:"+p.Name);
        }
    }
}
