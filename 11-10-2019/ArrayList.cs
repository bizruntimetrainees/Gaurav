using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace _11_10_2019
{
    public interface ITest
    {
       
        void PrintValues(IEnumerable value);
        
    }
     public class  TestInterface : ITest
    {

        public void PrintValues(IEnumerable value)
        {
            
            foreach(Object v in value)
            {
                Console.WriteLine("Values:");
                Console.WriteLine(v);
            }
        }
    }
    class ArrayList1
    {
        static void Main(string[] args)
        {
            TestInterface t = new TestInterface();
            ArrayList list = new ArrayList();
            list.Add("OM");
            list.Add("Namah");
            list.Add("Shivay");
            Console.WriteLine("total element:" + list.Count);
            Console.WriteLine("capacity:" + list.Capacity);
            t.PrintValues(list);
            
        }
    }
}
