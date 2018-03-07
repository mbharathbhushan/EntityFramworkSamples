using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _18_TPHInheritenceInEF_DFA;

namespace _18_TPHInheritenceInEF_DFA.Controllers
{
    public class PermanentEmployeesController : Controller
    {
        private EmployeeDbContext db = new EmployeeDbContext();

        // GET: PermanentEmployees
        public ActionResult Index()
        {
            return View(db.Employees.ToList().Cast<PermanentEmployee>());
        }

        // GET: PermanentEmployees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PermanentEmployee permanentEmployee = (PermanentEmployee)db.Employees.Find(id);
            if (permanentEmployee == null)
            {
                return HttpNotFound();
            }
            return View(permanentEmployee);
        }

        // GET: PermanentEmployees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PermanentEmployees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,Gender,AnuualSalary")] PermanentEmployee permanentEmployee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(permanentEmployee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(permanentEmployee);
        }

        // GET: PermanentEmployees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PermanentEmployee permanentEmployee = (PermanentEmployee)db.Employees.Find(id);
            if (permanentEmployee == null)
            {
                return HttpNotFound();
            }
            return View(permanentEmployee);
        }

        // POST: PermanentEmployees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,Gender,AnuualSalary")] PermanentEmployee permanentEmployee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(permanentEmployee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(permanentEmployee);
        }

        // GET: PermanentEmployees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PermanentEmployee permanentEmployee = (PermanentEmployee)db.Employees.Find(id);
            if (permanentEmployee == null)
            {
                return HttpNotFound();
            }
            return View(permanentEmployee);
        }

        // POST: PermanentEmployees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PermanentEmployee permanentEmployee = (PermanentEmployee)db.Employees.Find(id);
            db.Employees.Remove(permanentEmployee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
