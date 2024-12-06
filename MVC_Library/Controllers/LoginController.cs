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
    public class LoginController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        // GET: Login
        [HttpGet]
        public ActionResult Loging()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Loging(TblMember p)
        {
            var value = db.TblMembers.FirstOrDefault(x => x.memberMail == p.memberMail && x.memberPassword == p.memberPassword);
            if (value != null)
            {
                FormsAuthentication.SetAuthCookie(value.memberMail, false);
                Session["Mail"] = value.memberMail.ToString();
                return RedirectToAction("Index", "Student");
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