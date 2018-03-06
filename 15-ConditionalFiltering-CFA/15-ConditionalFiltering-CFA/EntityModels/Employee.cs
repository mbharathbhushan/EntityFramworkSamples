using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _15_ConditionalFiltering_CFA.EntityModels
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public bool IsTerminated { get; set; }
    }
}