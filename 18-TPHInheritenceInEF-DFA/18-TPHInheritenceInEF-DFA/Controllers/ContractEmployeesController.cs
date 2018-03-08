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
    public class ContractEmployeesController : Controller
    {
        private EmployeeDbContext db = new EmployeeDbContext();

        // GET: ContractEmployees
        public ActionResult Index()
        {
            var list = db.Employees.OfType<ContractEmployee>().ToList();
            return View(list);
        }

        // GET: ContractEmployees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContractEmployee contractEmployee = (ContractEmployee)db.Employees.Find(id);
            if (contractEmployee == null)
            {
                return HttpNotFound();
            }
            return View(contractEmployee);
        }

        // GET: ContractEmployees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContractEmployees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,Gender,HourlyPay,HoursWorked")] ContractEmployee contractEmployee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(contractEmployee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contractEmployee);
        }

        // GET: ContractEmployees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContractEmployee contractEmployee = (ContractEmployee)db.Employees.Find(id);
            if (contractEmployee == null)
            {
                return HttpNotFound();
            }
            return View(contractEmployee);
        }

        // POST: ContractEmployees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,Gender,HourlyPay,HoursWorked")] ContractEmployee contractEmployee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contractEmployee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contractEmployee);
        }

        // GET: ContractEmployees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContractEmployee contractEmployee = (ContractEmployee)db.Employees.Find(id);
            if (contractEmployee == null)
            {
                return HttpNotFound();
            }
            return View(contractEmployee);
        }

        // POST: ContractEmployees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContractEmployee contractEmployee = (ContractEmployee)db.Employees.Find(id);
            db.Employees.Remove(contractEmployee);
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
