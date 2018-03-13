using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _23_ManyToManyRelationShip_CFA.Contexts;

namespace _23_ManyToManyRelationShip_CFA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeDbContext db = new EmployeeDbContext();

            var list = db.Courses.ToList();
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