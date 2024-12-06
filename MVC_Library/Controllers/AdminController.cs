using MVC_Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Library.Controllers
{
    [AllowAnonymous]
    public class AdminController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        // GET: Admin
        public ActionResult Index()
        {
            var values = db.TblAdmins.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(TblAdmin p)
        {
            db.TblAdmins.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var value = db.TblAdmins.Find(id);
            db.TblAdmins.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var value = db.TblAdmins.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult Edit(TblAdmin p)
        {
            var value = db.TblAdmins.Find(p.adminId);
            value.adminUsername = p.adminUsername;
            value.adminPassword = p.adminPassword;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}