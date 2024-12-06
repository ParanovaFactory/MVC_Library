using MVC_Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Library.Controllers
{
    public class BookHistoryController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        // GET: BookHistory
        public ActionResult Index()
        {
            var user = (string)Session["Mail"].ToString();
            var id = db.TblMembers.Where(x => x.memberMail == user.ToString()).Select(z => z.memberId).FirstOrDefault();
            var values = db.TblOperations.Where(x => x.operationMember == id).ToList();
            return View(values);
        }
    }
}