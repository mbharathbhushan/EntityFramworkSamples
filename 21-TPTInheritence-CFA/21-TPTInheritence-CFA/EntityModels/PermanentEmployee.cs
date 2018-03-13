using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _21_TPTInheritence_CFA.EntityModels
{
    [Table("PermanentEmployees")]
    public class PermanentEmployee : Employee
    {
        public int AnnualSalary { get; set; }
    }
}