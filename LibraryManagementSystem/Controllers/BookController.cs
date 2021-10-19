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
        // GET: Book
        public ActionResult Index()
        {
            var books = db.BOOK_TABLE.ToList();
            return View(books);
        }
    }
}