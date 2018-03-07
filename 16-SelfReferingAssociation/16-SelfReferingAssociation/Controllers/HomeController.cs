using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_SelfReferingAssociation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeDbContext dbContext = new EmployeeDbContext();
            var count = dbContext.Employees.ToList();

            var mangerList = new List<Employee>();

            var subOrdinateList = new List<Employee>();

            foreach(var emp in count)
            {
                subOrdinateList.AddRange(emp.SubOrdinates);

                if(emp.Manager == null)
                {
                    mangerList.Add(null);
                }
                else
                {
                    mangerList.Add(emp.Manager);
                }
            }

            var subOrdinateListCount = subOrdinateList.Distinct().ToList().Count; 
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