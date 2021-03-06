﻿using CodeFirstSample.Repository;
using System.Linq;
using System.Web.Mvc;

namespace CodeFirstSample.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeRepository employeeRepository;
        public ActionResult Index()
        {
            employeeRepository = new EmployeeRepository();
            var list = employeeRepository.GetDepartments();
            var count = list.Count();

            var emp = employeeRepository.GetEmployee(1);
            var rec = emp;
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