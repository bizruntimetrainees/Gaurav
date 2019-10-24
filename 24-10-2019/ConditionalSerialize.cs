using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace _24_10_2019
{
    public class Employee
    {
        public string emp_Name { get; set; }
        public Employee Manager { get; set; }

        public bool ManagerSerialize()
        {
            

            return (Manager != this);
        }
    }
    class ConditionalSerialize
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.emp_Name = "Joe Employee";
            Employee shubbu = new Employee();
            shubbu.emp_Name = "Mike Manager";

            emp.Manager = shubbu;

            shubbu.Manager = shubbu;

            string json = JsonConvert.SerializeObject(new[] { emp, shubbu }, Formatting.Indented);

            Console.WriteLine(json);
            emp.ManagerSerialize();
        }
    }
}
