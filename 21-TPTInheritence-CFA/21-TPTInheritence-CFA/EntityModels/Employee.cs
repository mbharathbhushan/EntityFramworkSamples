﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _21_TPTInheritence_CFA.EntityModels
{
    [Table("Employees")]
    public class Employee
    {

        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }
    }
}