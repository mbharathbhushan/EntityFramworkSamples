using CodeFirstSample.DBContext;
using CodeFirstSample.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstSample.Repository
{
    public class EmployeeRepository
    {
        public List<Department> GetDepartments()
        {
            return new EmployeeDBContext().Departments.Include("Employees").ToList();
        }

        public Employee GetEmployee(int empId)
        {
            return new EmployeeDBContext().Employees.Include("Department").Where(x => x.Id == empId).FirstOrDefault();
        }
    }
}