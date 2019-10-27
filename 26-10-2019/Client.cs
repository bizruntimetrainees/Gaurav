using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSQL
{
    class Client
    {
        static void Main(string[] args)
        {
            CustomerPersistence cp = new CustomerPersistence();
            Customer cus = new Customer { ID = 3, NAME = "Soham", ADDRESS = "Blr" };
            Customer cus1 = new Customer { ID = 4, NAME = "Mohit", ADDRESS = "Blr" };
            Customer cus2 = new Customer { ID = 5, NAME = "Sohan", ADDRESS = "Blr" };
            Customer cus3 = new Customer { ID = 6, NAME = "Rahul", ADDRESS = "Blr" };
            
            cp.CreateCustomer(cus);
            cp.CreateCustomer(cus1);
            cp.CreateCustomer(cus2);
            cp.CreateCustomer(cus3);
            cp.Read();
            cp.Update();
            cp.Delete();
            //cp.CreateColumn();
            cp.ReadAgain();



        }
    }
}
