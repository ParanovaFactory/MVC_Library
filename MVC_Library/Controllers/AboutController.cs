using MVC_Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Library.Controllers
{
    public class AboutController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        public ActionResult Index()
        {
            var values = db.TblAbouts.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var value = db.TblAbouts.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult Edit(TblAbout tbl)
        {
            var value = db.TblAbouts.Find(tbl.abloutid);
            value.abloutTitle = tbl.abloutTitle;
            value.aboutContent = tbl.aboutContent;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}