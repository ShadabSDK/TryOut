using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryOutExtensionMethod;

namespace TryOutExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.ValidateName("Shadab");
            string s= "Hello Extension Methods";
            Console.WriteLine(s.WordCount());
            Console.ReadKey();
        }
    }
}
