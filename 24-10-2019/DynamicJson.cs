using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace JsonProject1
{
    class DynamicJson
    {
       public class Student
        {
            public string name;
            public int rollno;
            public string branch;
            public string address;
        }

        public static void GetDetails()
        {
            Console.WriteLine("Enter the size of Array:");
             int size=Convert.ToInt32(Console.ReadLine());

            Student[] sarray = new Student[size];
            for(int i=0;i<size;i++)
            {
                sarray[i] = new Student();
                Console.WriteLine("Enter Student's Name:");
                sarray[i].name = Console.ReadLine();
            }

            for (int i = 0; i < size; i++)
            {
                
                Console.WriteLine("Enter Student's rolllno:");
                sarray[i].rollno = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < size; i++)
            {
                
                Console.WriteLine("Enter Student's Branch:");
                sarray[i].branch = Console.ReadLine();
            }

            for (int i = 0; i < size; i++)
            {
                
                Console.WriteLine("Enter Student's address:");
                sarray[i].address = Console.ReadLine();
            }

            string serialize = JsonConvert.SerializeObject(sarray);
            Console.WriteLine("After Serialization..");
            Console.WriteLine(serialize);

           List<Student> deserialize = JsonConvert.DeserializeObject<List<Student>>(serialize);
            Console.WriteLine("After Deserialization..");
            foreach (var list in deserialize)
            {
                Console.WriteLine("Name:"+list.name+"\nRollno: "+list.rollno+" \nbranch:"
                    +list.branch+"\naddress:"+list.address);
            }
            
        }
        static void Main(string[] args)
        {
            try
            {
                DynamicJson.GetDetails();
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong.." + e.ToString());
            }
        }
    }
}
