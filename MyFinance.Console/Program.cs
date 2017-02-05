using MyFinance.Data;
using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ContextFinance ctx = new ContextFinance();
            ctx.Database.CreateIfNotExists();
            //  Product p = new Product { Name = "p1" };
           // Provider p = new Product { Username = "jjj" };
            //Address adr = new Address { City = "ttt" };
           // ctx.Product.Add(p);
           // ctx.SaveChanges();
        }
    }
}
