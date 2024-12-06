using MVC_Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Library.Controllers
{
    public class EmployeeController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        // GET: Employee
        public ActionResult Index()
        {
            var values = db.TblEmployees.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(TblEmployee p)
        {
            db.TblEmployees.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var value = db.TblEmployees.Find(id);
            db.TblEmployees.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var value = db.TblEmployees.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult Edit(TblEmployee p)
        {
            var value = db.TblEmployees.Find(p.employeeId);
            value.employeeNameSurname = p.employeeNameSurname;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}