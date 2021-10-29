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

        public ActionResult Index(string searchInput)
        {
            var books = from allBooks in db.BOOK_TABLE select allBooks;
            if (!string.IsNullOrEmpty(searchInput))
            {
                books = books.Where(book => book.NAME.Contains(searchInput));
            }
            //var books = db.BOOK_TABLE.ToList();
            return View(books.ToList());
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

        public ActionResult DeleteBook(int id)
        {
            var book = db.BOOK_TABLE.Find(id);
            db.BOOK_TABLE.Remove(book);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetBook(int id)
        {
            var book = db.BOOK_TABLE.Find(id);
            //get category from its table and send to page with viewbag
            var categoryList = db.CATEGORY_TABLE.ToList();
            List<SelectListItem> categoryItem = (List<SelectListItem>)(from category in categoryList select new SelectListItem { Text = category.NAME, Value = category.ID.ToString() }).ToList();
            ViewBag.categoryItem = categoryItem;

            //get author from its table and send to page with viewbag
            var authorList = db.AUTHOR_TABLE.ToList();
            List<SelectListItem> authorItem = (List<SelectListItem>)(from author in authorList select new SelectListItem { Text = author.NAME + " " + author.SURNAME, Value = author.ID.ToString() }).ToList();
            ViewBag.authorItem = authorItem;

            return View("GetBook", book);
        }

        public ActionResult UpdateBook(BOOK_TABLE bookObj) //makes post action
        {
            var book = db.BOOK_TABLE.Find(bookObj.ID);
            book.NAME = bookObj.NAME;
            var category = db.CATEGORY_TABLE.Where(c => c.ID == bookObj.CATEGORY_TABLE.ID).FirstOrDefault();
            book.CATEGORY = category.ID;
            var author = db.AUTHOR_TABLE.Where(a => a.ID == bookObj.AUTHOR_TABLE.ID).FirstOrDefault();
            book.AUTHOR = author.ID;
            book.PRINTDATE = bookObj.PRINTDATE;
            book.PAGE = bookObj.PAGE;
            book.STATUS = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}