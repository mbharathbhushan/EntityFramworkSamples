using _15_ConditionalFiltering_CFA.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _15_ConditionalFiltering_CFA.Context
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().
                Map(x => x.Requires("IsTerminated")
                .HasValue(false))
                .Ignore(x => x.IsTerminated);
            base.OnModelCreating(modelBuilder);
        }
    }
}