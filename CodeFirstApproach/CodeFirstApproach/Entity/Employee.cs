﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApproach.Entity
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Department Department { get; set; }
    }
}