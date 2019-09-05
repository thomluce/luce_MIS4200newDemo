using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using luce_MIS4200.Models;

namespace luce_MIS4200.DAL
{
  
    public class SampleContext : DbContext //Inherits from DbContext
    {
        public SampleContext() : base("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use
         //   Database.SetInitializer(new MigrateDatabaseToLatestVersion<SampleContext, luce_MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }
        // Include each object here.  The value inside <> is the name of the class, 
        // the value outside should generally be the plural of the class name 
        //    and is the name used to reference the entity in code
        public DbSet<Customer> Customer { get; set; }


        // add this method - it will be used later
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

    }
}