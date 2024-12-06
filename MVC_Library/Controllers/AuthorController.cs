using MVC_Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Library.Controllers
{
    public class AuthorController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        // GET: Author
        public ActionResult Index()
        {
            var values = db.TblAuthors.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(TblAuthor tbl)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                db.TblAuthors.Add(tbl);
                db.SaveChanges();
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var value = db.TblAuthors.Find(id);
            db.TblAuthors.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var value = db.TblAuthors.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult Edit(TblAuthor tbl)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                var value = db.TblAuthors.Find(tbl.authorId);
                value.authorName = tbl.authorName;
                value.authorSurname = tbl.authorSurname;
                value.authorDetails = tbl.authorDetails;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}