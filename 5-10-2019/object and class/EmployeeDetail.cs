using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_and_class
{
    public class EmployeeDetail
    {
        public int emp_id;
        public string emp_name;
        public float emp_salary;

        public void insert(int i,string n,float s)
        {
            emp_id = i;
            emp_name = n;
            emp_salary = s;
        }
        public void display()
        {
            Console.WriteLine("employee id is;" + emp_id);
            Console.WriteLine("employee name is;" + emp_name);
            Console.WriteLine("employee salary is;" + emp_salary);
        
        }
        class Employee
        { 
            static void Main(String[] args)
            {
                EmployeeDetail e = new EmployeeDetail();

                e.emp_id = 224683;
                e.emp_name = "Gaurav Mishra";
                e.emp_salary = 22336.55f;

                e.insert(e.emp_id, e.emp_name, e.emp_salary);
                e.display();

                Console.WriteLine("details fetchd successfully..");
            }
        }

    }
}
