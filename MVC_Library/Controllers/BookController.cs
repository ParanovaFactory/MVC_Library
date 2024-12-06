using MVC_Library.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_Library.Controllers
{
    public class BookController : Controller
    {
        Db_LibraryEntities db = new Db_LibraryEntities();
        // GET: Book
        public ActionResult Index()
        {
            var values = db.TblBooks.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult Add()
        {
            List<SelectListItem> caategory = (from i in db.TblCategories.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = i.categoryName,
                                                  Value = i.categoryId.ToString()
                                              }).ToList();
            ViewBag.ctg = caategory;

            List<SelectListItem> author = (from i in db.TblAuthors.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.authorName,
                                               Value = i.authorId.ToString()
                                           }).ToList();
            ViewBag.ath = author;
            return View();
        }
        [HttpPost]
        public ActionResult Add(TblBook p)
        {
            var ctg = db.TblCategories.Where(x => x.categoryId == p.TblCategory.categoryId).FirstOrDefault();
            p.TblCategory = ctg;

            var aut = db.TblAuthors.Where(x => x.authorId == p.TblAuthor.authorId).FirstOrDefault();
            p.TblAuthor = aut;

            db.TblBooks.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var value = db.TblBooks.Find(id);
            db.TblBooks.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var value = db.TblBooks.Find(id);

            List<SelectListItem> caategory = (from i in db.TblCategories.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = i.categoryName,
                                                  Value = i.categoryId.ToString()
                                              }).ToList();
            ViewBag.ctg = caategory;

            List<SelectListItem> author = (from i in db.TblAuthors.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.authorName,
                                               Value = i.authorId.ToString()
                                           }).ToList();
            ViewBag.ath = author;
            return View("Edit", value);
        }
        [HttpPost]
        public ActionResult Edit(TblBook p)
        {
            var ctg = db.TblCategories.Where(x => x.categoryId == p.TblCategory.categoryId).FirstOrDefault();
            p.TblCategory = ctg;

            var aut = db.TblAuthors.Where(x => x.authorId == p.TblAuthor.authorId).FirstOrDefault();
            p.TblAuthor = aut;

            var value = db.TblBooks.Find(p.bookId);
            value.bookName = p.bookName;
            value.bookCategory = p.TblCategory.categoryId;
            value.bookAuthor = p.TblAuthor.authorId;
            value.bookRelase = p.bookRelase;
            value.bookPublisher = p.bookPublisher;
            value.bookPages = p.bookPages;
            value.bookStatus = p.bookStatus;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}