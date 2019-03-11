using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryOutActionFuncPredicate
{
    class Customer

    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> action = new Action<string>(Display);
            action("HEllo!");

            Func<int, double> func = new Func<int, double>(CalculateHra);
            Console.WriteLine(func(10));

            List<Customer> custList = new List<Customer>();

            custList.Add(new Customer { Id = 1, FirstName = "Joydip", LastName = "Kanjilal", State = "Telengana", City = "Hyderabad", Address = "Begumpet", Country = "India" });

            custList.Add(new Customer { Id = 2, FirstName = "Steve", LastName = "Jones", State = "OA", City = "New York", Address = "Lake Avenue", Country = "US" });

            Predicate<Customer> hydCustomers = x => x.Id == 1;

            Customer customer = custList.Find(hydCustomers);

            Console.ReadKey();

        }
        static void Display(string message)

        {

            Console.WriteLine(message);

        }

        static double CalculateHra(int basic)

        {

            return (double)(basic * .4);

        }
    }
}
