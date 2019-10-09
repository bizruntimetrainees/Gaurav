using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
     class InvalidAgeException : System.Exception
    {
        public InvalidAgeException(String message) : base(message)

        {
           
        }
    }
    public class UserDefineException
    {
        static void validate(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 18");
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                validate(12);
            }
            catch (InvalidAgeException e) { Console.WriteLine(e); }
            Console.WriteLine("Rest of the code");
        }
    }
}
