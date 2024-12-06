using MVC_Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Library.Controllers
{
    public class StudentController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        // GET: Student
        [HttpGet]
        public ActionResult Index()
        {
            var user = (string)Session["Mail"];
            var value = db.TblMembers.FirstOrDefault(x => x.memberMail == user);
            return View(value);
        }

        [HttpPost]
        public ActionResult Index2(TblMember p)
        {
            var user = (string)Session["Mail"];
            var member = db.TblMembers.FirstOrDefault(x => x.memberMail == user);
            member.memberName = p.memberName;
            member.memberSurname = p.memberSurname;
            member.memberPhone = p.memberPhone;
            member.memberUsername = p.memberUsername;
            member.memberPassword = p.memberPassword;
            member.memberSchool = p.memberSchool;
            member.memberPhoto = p.memberPhoto;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}