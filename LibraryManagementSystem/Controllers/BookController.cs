using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryManagementSystem.Models.Entity;


namespace LibraryManagementSystem.Controllers
{
    public class BookController : Controller
    {
        DB_LIBRARYEntities db = new DB_LIBRARYEntities();
        
        public ActionResult Index()
        {
            var books = db.BOOK_TABLE.ToList();
            return View(books);
        }

        [HttpGet]
        public ActionResult AddBook()
        {
            //get category from its table and send to page with viewbag
            var categoryList = db.CATEGORY_TABLE.ToList();
            List<SelectListItem> categoryItem = (List<SelectListItem>)(from category in categoryList select new SelectListItem { Text = category.NAME, Value = category.ID.ToString() }).ToList();
            ViewBag.categoryItem = categoryItem;

            //get author from its table and send to page with viewbag
            var authorList = db.AUTHOR_TABLE.ToList();
            List<SelectListItem> authorItem = (List<SelectListItem>)(from author in authorList select new SelectListItem { Text = author.NAME + " "+author.SURNAME, Value = author.ID.ToString() }).ToList();
            ViewBag.authorItem = authorItem;

            return View();
        }

        [HttpPost]
        public ActionResult AddBook(BOOK_TABLE book)
        {
            //before post ı need to send id's of category and author
            var category = db.CATEGORY_TABLE.Where(c => c.ID == book.CATEGORY_TABLE.ID).FirstOrDefault();
            var author = db.AUTHOR_TABLE.Where(a => a.ID == book.AUTHOR_TABLE.ID).FirstOrDefault();
            book.AUTHOR_TABLE = (AUTHOR_TABLE)author;
            book.CATEGORY_TABLE = (CATEGORY_TABLE)category;

            db.BOOK_TABLE.Add(book);
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }
    }
}