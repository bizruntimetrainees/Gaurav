using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace _24_10_2019
{
    class FileSerialize
    {
        public class Movie
        {
            public string name;
           public int year; 
        }

        public static void GetDetails()
        {
            Console.WriteLine("Enter the Size of Array:");
            int size = Convert.ToInt32(Console.ReadLine());
            Movie[] movie = new Movie[size];

            for(int i=0;i<size;i++)
            {
                movie[i] = new Movie();
                Console.WriteLine("Enter the Name of Movie:");
                var name = Console.ReadLine();
                movie[i].name = name;
            }
            for (int i = 0; i < size; i++)
            {
                
                Console.WriteLine("Enter the year of release:");
                movie[i].year = Convert.ToInt32(Console.ReadLine());
            }

            File.WriteAllText("D:\\Gaurav\\bizruntime\\json\\json.txt", JsonConvert.SerializeObject(movie));
            

            var data = File.ReadAllText("D:\\Gaurav\\bizruntime\\json\\json.txt");


            List<Movie> deserialize = JsonConvert.DeserializeObject<List<Movie>>(data);
            
            foreach(var f in deserialize)
            {
                var st= f.name+"-"+ f.year;
                File.WriteAllText("D:\\Gaurav\\bizruntime\\json\\json.txt", data);
                File.WriteAllText("D:\\Gaurav\\bizruntime\\json\\json.txt", st);
               

            }

        }
        static void Main(string[] args)
        {
            try
            {
                FileSerialize.GetDetails();
            }
            catch(JsonSerializationException jsone)
            {
                Console.WriteLine("something went wrong..plzz check ur code.."+jsone.ToString());
            }
            
        }
    }
}
