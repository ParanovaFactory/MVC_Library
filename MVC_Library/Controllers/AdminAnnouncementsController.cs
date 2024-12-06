using MVC_Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Library.Controllers
{
    public class AdminAnnouncementsController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        // GET: AdminAnnouncements
        public ActionResult Index()
        {
            var values = db.TblAnnouncements.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(TblAnnouncement p)
        {
            db.TblAnnouncements.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var value = db.TblAnnouncements.Find(id);
            db.TblAnnouncements.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var value = db.TblAnnouncements.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult Edit(TblAnnouncement p)
        {
            var value = db.TblAnnouncements.Find(p.announcementId);
            value.announcementContext = p.announcementContext;
            value.announcementCategory = p.announcementCategory;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}