using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryManagementSystem.Models.Entity;

namespace LibraryManagementSystem.Controllers
{
    public class AuthorController : Controller
    {
        DB_LIBRARYEntities db = new DB_LIBRARYEntities();
        // GET: Author
        public ActionResult Index()
        {
            var values = db.AUTHOR_TABLE.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddAuthor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAuthor(AUTHOR_TABLE authorObj)
        {
            db.AUTHOR_TABLE.Add(authorObj);
            db.SaveChanges();
            return View();
        }

        public ActionResult DeleteAuthor(int id)
        {
            var author = db.AUTHOR_TABLE.Find(id);
            db.AUTHOR_TABLE.Remove(author);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetAuthor(int id)
        {
            var author = db.AUTHOR_TABLE.Find(id);
            return View("GetAuthor", author);
        }

        public ActionResult UpdateAuthor(AUTHOR_TABLE authorObj)
        {
            var author = db.AUTHOR_TABLE.Find(authorObj.ID);
            author.NAME = authorObj.NAME;
            author.SURNAME = authorObj.SURNAME;
            author.DETAIL = authorObj.DETAIL;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}