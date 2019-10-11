using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace _11_10_2019
{
    public interface IsTest
    {

        void PrintValues(IEnumerable value);

    }
    public class TestSInterface : IsTest
    {

        public void PrintValues(IEnumerable value)
        {

            foreach (Object v in value)
            {
                Console.WriteLine("Values:");
                Console.WriteLine(v);
            }
        }
    }
  
        class IsFixedSizeProperty
    {
            static void Main(string[] args)
            {
                TestInterface t = new TestInterface();
                ArrayList list = new ArrayList();
                list.Add("OM");
                list.Add("Namah");
                list.Add("Shivay");
            Console.WriteLine("this ArrayList in IsFixedSize:" + list.IsFixedSize);
            t.PrintValues(list);

            }
        }
}
