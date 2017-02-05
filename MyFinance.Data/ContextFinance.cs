using MyFinance.Data.Configurations;
using MyFinance.Data.CustumConventions;
using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MyFinance.Domain.Entities;

namespace MyFinance.Data
{
    public class ContextFinance:DbContext 
    {
        public ContextFinance() : base("basefinance")
        {

        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Provider> Provider { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Properties<int>().Where(x => x.Name == "Ahmed").Configure(x => x.IsKey());

            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new AddressConfiguration());
            modelBuilder.Conventions.Add(new DateTime2Convention());

        }


    }
}
