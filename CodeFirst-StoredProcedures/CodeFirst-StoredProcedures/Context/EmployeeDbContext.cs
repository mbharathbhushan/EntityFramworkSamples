using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CodeFirst_StoredProcedures.EntityModels;

namespace CodeFirst_StoredProcedures.Context
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employeees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>().MapToStoredProcedures();

            //For Custom Stored Procedure Nam & Custom Parameters
            modelBuilder.Entity<Employee>().MapToStoredProcedures(x => x.Insert(i => i.HasName("InsertEmployee"))
                                                                    .Update(u => u.HasName("UpdateEmployee"))
                                                                    .Delete(d => d.HasName("DelteEmployee").Parameter(id => id.ID, "EmpID")));
            base.OnModelCreating(modelBuilder);
        }
    }
}