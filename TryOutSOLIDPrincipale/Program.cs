using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryOutSOLIDPrincipale
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liskov
            var database = new Database();
            var customers = new List<Customer>
                    {
                        new GoldCustomer(),
                        new SilverCustomer(),
                        new Enquiry() // This is valid, but...
                    };

            foreach(Customer c in customers)
            {
                c.Add(database);
            }
        }
    }
}
