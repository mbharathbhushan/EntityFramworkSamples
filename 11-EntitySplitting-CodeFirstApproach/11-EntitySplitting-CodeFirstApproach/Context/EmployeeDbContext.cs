using _11_EntitySplitting_CodeFirstApproach.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _11_EntitySplitting_CodeFirstApproach.Context
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Map(x =>
                {
                    x.Properties(p => new
                    {
                        p.EmployeeID,
                        p.FirstName,
                        p.LastName,
                        p.Gender
                    });
                    x.ToTable("Employees");
                })

            .Map(map =>
        {
            map.Properties(p => new
            {
                p.Email,
                p.LandLine,
                p.Mobile
            });

            map.ToTable("EmployeeContactDetails");
        });
            base.OnModelCreating(modelBuilder);
        }
    }
}