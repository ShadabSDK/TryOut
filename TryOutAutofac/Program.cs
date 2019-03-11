using Autofac;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryOutAutofac
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            //Dependency Injection by Hand

            IQueryable<Memo> memos = new List<Memo>() {
                        new Memo { Title = "Release Autofac 1.0", DueAt = new DateTime(2007, 12, 14) },
                        new Memo { Title = "Write CodeProject Article", DueAt = DateTime.Now },
                        new Memo { Title = "Release Autofac 2.3", DueAt = new DateTime(2010, 07, 01) }
                }.AsQueryable();

            //var memos = new List<Memo> {
            //    new Memo { Title = "Release Autofac 1.1", DueAt = new DateTime(2007, 03, 12) },
            //    new Memo { Title = "Update CodeProject Article", DueAt = DateTime.Now },
            //    new Memo { Title = "Release Autofac 3", DueAt = new DateTime(2011, 07, 01) }
            //};

           // var checker = new MemoChecker(memos, new PrintingNotifier(Console.Out));
           // checker.CheckAndNotify();

            builder.Register(c => new MemoChecker(c.Resolve<IQueryable<Memo>>(),
                                                   c.Resolve<IMemoDueNotifier>()));
            builder.RegisterType<PrintingNotifier>().As<IMemoDueNotifier>();
            builder.RegisterInstance(memos).As<IQueryable<Memo>>();
            builder.RegisterInstance(Console.Out).As<TextWriter>().ExternallyOwned();

            using (var container = builder.Build())
            {
                container.Resolve<MemoChecker>().CheckAndNotify();
            }

                //Registering a Component Created with an Expression


                Console.ReadKey();
        }
    }
}
