using System;
using System.Collections.Generic;
using System.Text;

namespace JsonProject1
{
    class MailAccount
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Getting Account Details...");
                SerializedDeserializedAccount sda = new SerializedDeserializedAccount();
                sda.GetDetails();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.." + e.ToString());
            }
            finally
            {
                Console.WriteLine("finally block is executed...");
            }
        }
    }
}
