﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst_StoredProcedures.EntityModels
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }
}