using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _13_TableSplitting_CodeFirstApproach.EntityModels;

namespace _13_TableSplitting_CodeFirstApproach.EntityModels
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public EmployeeContactDetail EmployeeContactDetail { get; set; }
    }
}