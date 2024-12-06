using MVC_Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Library.Controllers
{
    public class StatisticController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        // GET: Statistic
        public ActionResult Index()
        {
            var cash = db.TblCashregisters.Sum(x => x.cashregisterAmount).ToString();
            ViewBag.cashregisterAmount = cash;
            var user = db.TblMembers.Count().ToString();
            ViewBag.members = user;
            var book = db.TblBooks.Count().ToString();
            ViewBag.books = book;
            var bookRent = db.TblBooks.Where(x => x.bookStatus == false).Count().ToString();
            ViewBag.bookRented = bookRent;
            return View();
        }

        public ActionResult Weather()
        {
            return View();
        }

        public ActionResult WeatherCard()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Upload(HttpPostedFileBase file)
        {
            if (file.ContentLength > 0)
            {
                string filepaht = Path.Combine(Server.MapPath("~/web2/gallery/"),Path.GetFileName(file.FileName));
                file.SaveAs(filepaht);
            }
            return RedirectToAction("Gallery");
        }
    }
}