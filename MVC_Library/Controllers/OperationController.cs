using MVC_Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_Library.Controllers
{
    public class OperationController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        // GET: Operation
        public ActionResult Index()
        {
            var values = db.TblOperations.ToList();
            return View(values);
        }

        public ActionResult Delete(int id)
        {
            var value = db.TblOperations.Find(id);
            db.TblOperations.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var value = db.TblOperations.Find(id);

            List<SelectListItem> member = (from i in db.TblMembers.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.memberName + " " + i.memberSurname,
                                               Value = i.memberId.ToString()
                                           }).ToList();
            ViewBag.mbr = member;

            List<SelectListItem> book = (from i in db.TblBooks.ToList()
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
            return View(value);
        }
        [HttpPost]
        public ActionResult Edit(TblOperation p)
        {
            var value = db.TblOperations.Find(p.operationId);

            var book = db.TblBooks.Where(x => x.bookId == p.TblBook.bookId).FirstOrDefault();
            p.TblBook = book;

            var mbr = db.TblMembers.Where(x => x.memberId == p.TblMember.memberId).FirstOrDefault();
            p.TblMember = mbr;

            var emp = db.TblEmployees.Where(x => x.employeeId == p.TblMember.memberId).FirstOrDefault();
            p.TblEmployee = emp;

            value.operationBook = p.TblBook.bookId;
            value.operationMember = p.TblMember.memberId;
            value.operationEmployee = p.TblEmployee.employeeId;
            value.operationGetDate = p.operationGetDate;
            value.operationBackDate = p.operationBackDate;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}