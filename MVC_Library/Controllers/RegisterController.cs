using MVC_Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Library.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        // GET: Register
        [HttpGet]
        public ActionResult Registering()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registering(TblMember p)
        {
            if (!ModelState.IsValid) 
            {
                return View("Registering");
            }
            db.TblMembers.Add(p);
            db.SaveChanges();
            return View();
        }
    }
}