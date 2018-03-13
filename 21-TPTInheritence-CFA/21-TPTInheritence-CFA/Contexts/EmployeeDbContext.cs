using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using _21_TPTInheritence_CFA.EntityModels;
namespace _21_TPTInheritence_CFA.Contexts
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}