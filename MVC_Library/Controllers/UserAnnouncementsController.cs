using MVC_Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Library.Controllers
{
    public class UserAnnouncementsController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        // GET: UserAnnouncements
        public ActionResult Index()
        {
            var values = db.TblAnnouncements.ToList();
            return View(values);
        }
    }
}