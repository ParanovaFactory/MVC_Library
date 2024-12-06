using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Library.Models.Classes;
using MVC_Library.Models.Entity;

namespace MVC_Library.Controllers
{
    public class ChartController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Visualization()
        {
            return Json(list());
        }

        public List<Class2> list()
        {
            List<Class2> cs = new List<Class2>();
            cs.Add(new Class2()
            {
                Category = "Novel",
                bookNumber = 43
            });
            cs.Add(new Class2()
            {
                Category = "Story",
                bookNumber = 56
            });
            cs.Add(new Class2()
            {
                Category = "Action",
                bookNumber = 12
            });
            cs.Add(new Class2()
            {
                Category = "Comedy",
                bookNumber = 65
            });
            return cs;
        }
    }
}