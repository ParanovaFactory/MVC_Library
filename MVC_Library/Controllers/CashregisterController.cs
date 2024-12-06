using MVC_Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Library.Controllers
{
    public class CashregisterController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        // GET: Cashregister
        public ActionResult Index()
        {
            var values = db.TblCashregisters.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(TblCashregister p)
        {
            db.TblCashregisters.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var value = db.TblCashregisters.Find(id);
            db.TblCashregisters.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var value = db.TblCashregisters.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult Edit(TblCashregister p)
        {
            var value = db.TblCashregisters.Find(p.cashregisterId);
            value.cashregisterMonth = p.cashregisterMonth;
            value.cashregisterAmount = p.cashregisterAmount;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}