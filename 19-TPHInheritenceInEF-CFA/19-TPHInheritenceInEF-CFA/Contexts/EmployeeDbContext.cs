using _19_TPHInheritenceInEF_CFA.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _19_TPHInheritenceInEF_CFA.Contexts
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employee>().
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}