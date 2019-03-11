using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryOutBasics
{

    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animallllllllll");
        }
    }

    public class Cow: Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("MOOOOOOOOOOOO");
        }
    }

    public class Donkey : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Hee Haw");
        }
    }

    public class Lion : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Roarrrrrrrrrrrrrr");
        }
    }
    // Base Class

    public class BClass
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("Learn C# Tutorial");
        }
    }

    // Derived Class
    public class DClass : BClass
    {
        public override void GetInfo()
        {
            Console.WriteLine("Welcome to Tutlane");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int rand=System.Random

            //DClass d = new DClass();

            //d.GetInfo();

            //BClass b = new BClass();

            //b.GetInfo();

            //BClass baseclass = new DClass();
            //baseclass.GetInfo();

            Console.WriteLine("\nPress Enter Key to Exit..");

            Console.ReadLine();
        }
    }
}
