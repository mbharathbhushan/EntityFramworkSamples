using _13_TableSplitting_CodeFirstApproach.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _13_TableSplitting_CodeFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeDbContext dbContext = new EmployeeDbContext();

            var list = dbContext.Employees.ToList();
            var count = list.Count;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}