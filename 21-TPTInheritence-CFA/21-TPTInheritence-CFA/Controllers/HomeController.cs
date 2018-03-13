using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _21_TPTInheritence_CFA.Contexts;
using _21_TPTInheritence_CFA.EntityModels;

namespace _21_TPTInheritence_CFA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeDbContext dbcontext = new EmployeeDbContext();
            var contractEmployee = new PermanentEmployee() { FirstName = "Ramesh", Gender = "Male", AnnualSalary = 35, LastName="G" };

            dbcontext.Employees.Add(contractEmployee);
            dbcontext.SaveChanges();
            var list = dbcontext.Employees.ToList();
            var count = list;

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