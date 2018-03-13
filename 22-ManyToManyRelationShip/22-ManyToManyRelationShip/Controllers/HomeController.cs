using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _22_ManyToManyRelationShip.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeDbContext db = new EmployeeDbContext();

            db.Students.FirstOrDefault(x => x.StudentID == 1).Courses.Add(db.Courses.FirstOrDefault(y => y.CourseID == 4));
            db.SaveChanges();
            var list = (from student in db.Students
                        from course in student.Courses
                        select new
                        {
                            SName = student.StudentName,
                            CName = course.CourseName
                        }).ToList();

            var count = list.Count();

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