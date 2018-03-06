using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _11_EntitySplitting_CodeFirstApproach.EntityModels
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string LandLine { get; set; }
    }
}