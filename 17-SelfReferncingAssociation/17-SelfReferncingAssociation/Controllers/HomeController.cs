using _17_SelfReferncingAssociation.Context;
using _17_SelfReferncingAssociation.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17_SelfReferncingAssociation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            EmployeeDbContext dbContext = new EmployeeDbContext();
            var count = dbContext.Employees.ToList();

            var mangerList = new List<Employee>();

            foreach (var emp in count)
            {
                
                if (emp.Manager == null)
                {
                    mangerList.Add(null);
                }
                else
                {
                    mangerList.Add(emp.Manager);
                }
            }
            
            var list = mangerList.Distinct().ToList().Count;
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