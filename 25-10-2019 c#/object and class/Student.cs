using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_and_class
{
   public class Student
    {
       public int id;
       public string name;
       public  string add;
    }
     class TestStudent
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.id = 0012;
            st.name = "raghavendra";
            st.add = "Bangalore";
            Console.WriteLine(st.id);
            Console.WriteLine(st.name);
            Console.WriteLine(st.add);
            Console.WriteLine("Program success");

        }
    }
}
