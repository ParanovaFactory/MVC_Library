using MVC_Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_Library.Controllers
{
    [AllowAnonymous]
    public class AdminLoginController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        // GET: AdminLogin
        [HttpGet]
        public ActionResult Loging()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Loging(TblAdmin p)
        {
            var value = db.TblAdmins.FirstOrDefault(x => x.adminUsername == p.adminUsername && x.adminPassword == p.adminPassword);
            if (value != null)
            {
                FormsAuthentication.SetAuthCookie(value.adminUsername, false);
                return RedirectToAction("Index", "Author");
            }
            else
            {
                return View();
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Loging");
        }
    }
}