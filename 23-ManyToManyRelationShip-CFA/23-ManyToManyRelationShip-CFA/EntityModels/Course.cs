﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _23_ManyToManyRelationShip_CFA.EntityModels
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public IList<Student> Students { get; set; }
    }
}