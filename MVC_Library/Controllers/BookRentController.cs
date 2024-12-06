using MVC_Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_Library.Controllers
{
    public class BookRentController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        // GET: BookRent
        public ActionResult Index()
        {
            var values = db.TblBooks.Where(x => x.bookStatus == true).ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult Rent(int id)
        {

            List<SelectListItem> member = (from i in db.TblMembers.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.memberName + " " + i.memberSurname,
                                               Value = i.memberId.ToString()
                                           }).ToList();
            ViewBag.mbr = member;

            List<SelectListItem> book = (from i in db.TblBooks.ToList().Where(x => x.bookId == id).ToList()
                                         select new SelectListItem
                                         {
                                             Text = i.bookName,
                                             Value = i.bookId.ToString()
                                         }).ToList();
            ViewBag.bok = book;

            List<SelectListItem> employee = (from i in db.TblEmployees.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.employeeNameSurname,
                                                 Value = i.employeeId.ToString()
                                             }).ToList();
            ViewBag.emp = employee;
            return View();
        }
        [HttpPost]
        public ActionResult Rent(TblOperation p)
        {
            var rentBook = db.TblBooks.Find(p.TblBook.bookId);
            rentBook.bookStatus = false;

            var book = db.TblBooks.Where(x => x.bookId == p.TblBook.bookId).FirstOrDefault();
            p.TblBook = book;

            var mbr = db.TblMembers.Where(x => x.memberId == p.TblMember.memberId).FirstOrDefault();
            p.TblMember = mbr;

            var emp = db.TblEmployees.Where(x => x.employeeId == p.TblMember.memberId).FirstOrDefault();
            p.TblEmployee = emp;

            db.TblOperations.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}