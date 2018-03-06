using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _14_ConditionFiltering_DFA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeDbContext dbContext = new EmployeeDbContext();
            var employees = dbContext.Employees.ToList();
            var totalEmployees = employees.Count;
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