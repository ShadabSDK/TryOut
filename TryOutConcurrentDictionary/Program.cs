using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TryOutConcurrentDictionary
{
    class Program
    {
        static ConcurrentDictionary<string, int> _concurrent =
        new ConcurrentDictionary<string, int>();

        static Dictionary<string, int> _dictionary = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            //TestConcurrentDictionary();
            TestDictionary();
            Console.ReadKey();
        }

        void Pri()
        {
            Console.WriteLine();
        }

        public static void TestConcurrentDictionary()
        {
            Thread thread1 = new Thread(new ThreadStart(A));
            Thread thread2 = new Thread(new ThreadStart(A));
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            Console.WriteLine("Average: {0}", _concurrent.Values.Average());
        }

        public static void TestDictionary()
        {
            Thread thread1 = new Thread(new ThreadStart(B));
            Thread thread2 = new Thread(new ThreadStart(B));
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            Console.WriteLine("Average: {0}", _dictionary.Values.Average());
        }

        static void A()
        {
            for (int i = 0; i < 1000; i++)
            {
                _concurrent.TryAdd(i.ToString(), i);
            }
        }

        static void B()
        {
            for (int i = 0; i < 1000; i++)
            {
                _dictionary.Add(i.ToString(), i);
            }
        }
    }
}
