﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using _13_TableSplitting_CodeFirstApproach.EntityModels;

namespace _13_TableSplitting_CodeFirstApproach.Context
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasKey(pk => pk.EmployeeId).ToTable("Employees");
            modelBuilder.Entity<EmployeeContactDetail>().HasKey(pk => pk.EmployeeId).ToTable("Employees");
            modelBuilder.Entity<Employee>()
                .HasRequired(p => p.EmployeeContactDetail)
                .WithRequiredPrincipal(c => c.Employee);
            base.OnModelCreating(modelBuilder);
        }
    }
}