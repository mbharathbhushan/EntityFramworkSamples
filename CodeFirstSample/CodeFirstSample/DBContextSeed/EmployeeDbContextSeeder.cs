using System.Collections.Generic;
using System.Data.Entity;
using CodeFirstSample.DBContext;
using CodeFirstSample.EntityModels;

namespace CodeFirstSample.DBContextSeed
{
    public class EmployeeDbContextSeeder  : DropCreateDatabaseIfModelChanges<EmployeeDBContext>
    {
        protected override void Seed(EmployeeDBContext context)
        {
            Department department1 = new Department()
            {
                Location = "Hyderabad",
                Name = "Software",
                Employees = new List<Employee>()
                {
                    new Employee()
                    {
                        FirstName="Bharath Bhushan",
                        LastName="Manglpally",
                        Gender="M",
                        JobTitle="SSE",
                        Salary=25000
                    }
                }
            };

            context.Departments.Add(department1);
            base.Seed(context);
        }
    }
}