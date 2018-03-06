using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _13_TableSplitting_CodeFirstApproach.EntityModels
{
    public class EmployeeContactDetail
    {
        public int EmployeeId { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Landline { get; set; }
        public Employee Employee { get; set; }
    }
}