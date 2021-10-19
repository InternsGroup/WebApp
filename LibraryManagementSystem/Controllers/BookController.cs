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
            var categoryList = db.CATEGORY_TABLE.ToList();
            List<SelectListItem> categoryItem = (List<SelectListItem>)(from category in categoryList select new SelectListItem { Text = category.NAME, Value = category.ID.ToString() }).ToList();
            ViewBag.categoryItem = categoryItem;
            return View();
        }

        [HttpPost]
        public ActionResult AddBook(BOOK_TABLE book)
        {
            return View();
        }
    }
}