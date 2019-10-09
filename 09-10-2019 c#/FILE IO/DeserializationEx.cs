using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Text;

namespace _09_10_2019
{
    [Serializable]
   public class Student1
    {
        public int rolln;
       public  string name;
        public Student1(int rolln, string name)
        {
            this.rolln = rolln;
            this.name = name;
        }
    }
    class DeserializationEx
    {
        static void Main(string[] args)
        {


            FileStream file = new FileStream("D:\\Gaurav\\C#\\abc.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Student1 s = (Student1)formatter.Deserialize(file);
            Console.WriteLine("Rollno: " + s.rolln);
            Console.WriteLine("Name: " + s.name);
            file.Close();
            Console.WriteLine("Success:");


        }
    }
}
