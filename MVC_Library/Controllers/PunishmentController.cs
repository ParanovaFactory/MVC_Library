using MVC_Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Library.Controllers
{
    public class PunishmentController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        // GET: Punishment
        public ActionResult Index()
        {
            var values = db.TblPunishments.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult Add()
        {
            List<SelectListItem> member = (from i in db.TblMembers.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = i.memberName + " " +i.memberSurname,
                                                  Value = i.memberId.ToString()
                                              }).ToList();
            ViewBag.mbr = member;

            List<SelectListItem> operation = (from i in db.TblOperations.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.TblBook.bookName,
                                               Value = i.operationId.ToString()
                                           }).ToList();
            ViewBag.opt = operation;
            return View();
        }
        [HttpPost]
        public ActionResult Add(TblPunishment p)
        {
            var mbr = db.TblMembers.Where(x=>x.memberId == p.TblMember.memberId).FirstOrDefault();
            p.TblMember = mbr;

            var opt = db.TblOperations.Where(x => x.operationId == p.TblOperation.operationId).FirstOrDefault();
            p.TblOperation = opt;

            db.TblPunishments.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var value = db.TblPunishments.Find(id);
            db.TblPunishments.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var value = db.TblPunishments.Find(id);
            List<SelectListItem> member = (from i in db.TblMembers.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.memberName + " " + i.memberSurname,
                                               Value = i.memberId.ToString()
                                           }).ToList();
            ViewBag.mbr = member;

            List<SelectListItem> operation = (from i in db.TblOperations.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = i.TblBook.bookName,
                                                  Value = i.operationId.ToString()
                                              }).ToList();
            ViewBag.opt = operation;
            return View(value);
        }
        [HttpPost]
        public ActionResult Edit(TblPunishment p)
        {
            var value = db.TblPunishments.Find(p.punishmentId);

            var mbr = db.TblMembers.Where(x => x.memberId == p.TblMember.memberId).FirstOrDefault();
            p.TblMember = mbr;

            var opt = db.TblOperations.Where(x => x.operationId == p.TblOperation.operationId).FirstOrDefault();
            p.TblOperation = opt;

            value.punishmentMember = p.TblMember.memberId;
            value.punishmentOperation = p.TblOperation.operationId;
            value.punishmentStartDate = p.punishmentStartDate;
            value.punishmentEndDate = p.punishmentEndDate;
            value.punishmentFine = p.punishmentFine;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}