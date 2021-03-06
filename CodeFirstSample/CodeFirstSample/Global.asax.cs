﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using CodeFirstSample.DBContext;
using CodeFirstSample.DBContextSeed;

namespace CodeFirstSample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // when we want to create database with out data.
            ////Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EmployeeDBContext>());

            // if we want to create data along with schema
            Database.SetInitializer(new EmployeeDbContextSeeder());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
