using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Library.Models.Entity;
using MVC_Library.Models.Classes;

namespace MVC_Library.Controllers
{
    [AllowAnonymous]
    public class ShowCaseController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        // GET: ShowCase
        [HttpGet]
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Books = db.TblBooks.ToList();
            cs.Abouts = db.TblAbouts.ToList();
            return View(cs);
        }

        [HttpPost]
        public ActionResult Index(TblContact p)
        {
            db.TblContacts.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}