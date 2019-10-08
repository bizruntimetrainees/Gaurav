using System;
using System.Collections.Generic;
using System.Text;

namespace _06_10_2019
{
    public class Address
    {
        public string street;
        public string city;
        public string state;

        public Address(string street,string city,string state)
        {
            this.street = street;
            this.city = city;
            this.state = state;
        }
    }
     public class Employee
    {
        public int id;
        public string name;
        public int salary;
        public string profile;
        public Address address;

        public Employee(int id,string name,int salary,string profile,Address address)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.profile = profile;
            this.address = address;
        }

        public void information()
        {
            Console.WriteLine("Id:"+id);
            Console.WriteLine("Name:"+name);
            Console.WriteLine("Profile:"+profile);
            Console.WriteLine("Salary:"+salary);
            Console.WriteLine("Add1:"+address.street);
            Console.WriteLine("Add2:"+address.city);
            Console.WriteLine("Add3:"+address.state);

        }
    }
    class Has_A_Relationship
    {
        static void Main(string[] args)
        {
            Address ad = new Address("Balaji colony", "Morena", "MadhayaPradesh");
            Employee emp = new Employee(224683, "Gaurav Mishra", 50000, "Software Engineer", ad);
            emp.information();
        }
    }
}
