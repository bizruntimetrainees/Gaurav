using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using System.Collections.Generic;
using System.Text;

namespace _09_10_2019
{
    [Serializable]
    class Student
    {
        int rolln;
        string name;
         public  Student(int rolln, string name)
        {
            this.rolln = rolln;
            this.name = name;
        }
    }
    public class SerializationEx
    {
        static void Main(string[] args)
        {
            
            
                FileStream file = new FileStream("D:\\Gaurav\\C#\\abc.txt", FileMode.OpenOrCreate);
                BinaryFormatter formatter = new BinaryFormatter();

                Student s = new Student(1100868, "GauravMishra");
                formatter.Serialize(file, s);
                file.Close();
            Console.WriteLine("Success:");
            
            
        }
    }
}
