using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodeFirst_StoredProcedures.Context;
using CodeFirst_StoredProcedures.EntityModels;
namespace CodeFirst_StoredProcedures.Repository
{
    public class EmployeeRepository
    {
        EmployeeDbContext employeeDbContext = new EmployeeDbContext();

        public List<Employee> GetEmployees()
        {
            return employeeDbContext.Employeees.ToList();
        }

        public void InsertEmployees(Employee employee)
        {
            employeeDbContext.Employeees.Add(employee);
            employeeDbContext.SaveChanges();
        }

        public void UpdateEmployees(Employee employee)
        {
            var employeeToUpdate = employeeDbContext.Employeees.FirstOrDefault(x => x.ID == employee.ID);
            employeeToUpdate.Name = employee.Name;
            employeeToUpdate.Salary = employee.Salary;
            employeeToUpdate.Gender = employee.Gender;
            employeeDbContext.SaveChanges();
        }

        public void DeleteEmployees(Employee employee)
        {
            var employeeToDelete = employeeDbContext.Employeees.FirstOrDefault(x => x.ID == employee.ID);
            employeeDbContext.Employeees.Remove(employeeToDelete);
            employeeDbContext.SaveChanges();
        }

    }
}