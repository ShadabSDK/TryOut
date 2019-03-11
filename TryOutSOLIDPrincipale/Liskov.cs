using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryOutSOLIDPrincipale
{
    public class Database
    {
        public void Add()
        {
            Console.WriteLine("Add Databse");
        }
    }

    public interface IDiscount
    {
        int Discount(int sales);
    }

    public interface IDatabase
    {
        void Add(Database db);
    }

    public class Customer : IDiscount, IDatabase
    {
        public virtual int Discount(int sales) { return sales; }
        public virtual void Add(Database db) { db.Add(); }
    }

    //public class Customer
    //{
    //    public virtual void Add(Database db)
    //    {
    //        db.Add();
    //    }

    //    public virtual int Discount(int sales)
    //    {
    //        return sales;
    //    }
    //}

    public class Enquiry : Customer
    {
        public override int Discount(int sales)
        {
            return sales * 5;
        }

        public override void Add(Database db)
        {
            throw new Exception("Not allowed");
        }
    }

    public class GoldCustomer : Customer
    {
        public override int Discount(int sales)
        {
            return sales - 100;
        }
    }

    public class SilverCustomer : Customer
    {
        public override int Discount(int sales)
        {
            return sales - 50;
        }
    }

    public 
    class Liskov
    {
    }
}
