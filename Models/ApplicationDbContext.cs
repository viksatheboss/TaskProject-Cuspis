using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TaskProject.Models
{ 
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("AddressDbContext")
        {

        }

        public DbSet<People> People { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            


            base.OnModelCreating(modelBuilder);
        }

    }
}