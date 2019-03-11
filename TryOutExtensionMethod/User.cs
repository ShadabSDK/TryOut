using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryOutExtensionMethod
{
    public class User
    {
        public string Name { get; set; }
    }

    public static class UserExtension
    {
        public static void ValidateName(this User user,string name )
        {
            user.Name = name;
            Console.WriteLine(user.Name);

           
        }
    }
}
