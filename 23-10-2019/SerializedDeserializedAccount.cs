using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace JsonProject1
{
    public class SerializedDeserializedAccount
    {
        public void GetDetails()
        {
            Account account = new Account();


            account.Email = "gauravmishra@gamil.com";
            account.Active = true;
            account.CreatedDate = new DateTime(2013, 1, 20, 0, 0, 0, DateTimeKind.Utc);
            account.Roles = new List<string>();
            account.Roles.Add("User");
            account.Roles.Add("Admin");

            string json = JsonConvert.SerializeObject(account, Formatting.Indented);

            Account deserialize = JsonConvert.DeserializeObject<Account>(json);

            Console.WriteLine("Email :" + deserialize.Email);
            Console.WriteLine("Account is Active ? :" + deserialize.Active);
            Console.WriteLine("Date of Creation :" + deserialize.Active);
            Console.WriteLine("Roles...");

            foreach(string list in account.Roles)
            {
                Console.WriteLine(list);
            }

        }
       
    }
}
