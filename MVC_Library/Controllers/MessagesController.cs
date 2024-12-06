using MVC_Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Library.Controllers
{
    public class MessagesController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        // GET: Messages
        public ActionResult Index()
        {
            var user = (string)Session["Mail"].ToString();
            var values = db.TblMessages.Where(x => x.messageReceiver == user).ToList();
            return View(values);
        }

        public ActionResult Index2()
        {
            var user = (string)Session["Mail"].ToString();
            var values = db.TblMessages.Where(x => x.messageSender == user).ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(TblMessage p)
        {
            var user = (string)Session["Mail"];
            db.TblMessages.Add(p);
            p.messageSender = user;
            p.messageDate = DateTime.Now;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}