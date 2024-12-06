using MVC_Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_Library.Controllers
{
    public class CategoryController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        // GET: Category
        public ActionResult Index()
        {
            var values = db.TblCategories.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(TblCategory p)
        {
            db.TblCategories.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var value = db.TblCategories.Find(id);
            db.TblCategories.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var value = db.TblCategories.Find(id);
            return View("Edit",value);
        }
        [HttpPost]
        public ActionResult Edit(TblCategory tbl)
        {
            var value = db.TblCategories.Find(tbl.categoryId);
            value.categoryName = tbl.categoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}