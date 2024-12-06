using MVC_Library.Models.Entity;
using PagedList;
using PagedList.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Library.Controllers
{
    public class MemberController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        // GET: Meber
        public ActionResult Index(int page = 1)
        {
            var values = db.TblMembers.ToList().ToPagedList(page, 5);
            return View(values);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(TblMember p)
        {
            db.TblMembers.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var value = db.TblMembers.Find(id);
            db.TblMembers.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var value = db.TblMembers.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult Edit(TblMember p)
        {
            var value = db.TblMembers.Find(p.memberId);
            value.memberName = p.memberName;
            value.memberSurname = p.memberSurname;
            value.memberMail = p.memberMail;
            value.memberPhone = p.memberPhone;
            value.memberUsername = p.memberUsername;
            value.memberPassword = p.memberPassword;
            value.memberPhoto = p.memberPhoto;
            value.memberSchool = p.memberSchool;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}