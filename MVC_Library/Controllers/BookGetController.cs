using MVC_Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Library.Controllers
{
    public class BookGetController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        // GET: BookGet
        public ActionResult Index()
        {
            var values = db.TblBooks.Where(x => x.bookStatus == false).ToList();
            return View(values);
        }

        public ActionResult Get(int id)
        {
            var value = db.TblBooks.Find(id);
            value.bookStatus = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}