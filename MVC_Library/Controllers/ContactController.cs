using MVC_Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Library.Controllers
{
    public class ContactController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        // GET: Contact ADMIN
        public ActionResult Index()
        {
            var values = db.TblContacts.ToList();
            return View(values);
        }

        public ActionResult Details(int id)
        {
            var value = db.TblContacts.Find(id);
            return View(value);
        }
    }
}