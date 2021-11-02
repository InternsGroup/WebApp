using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryManagementSystem.Models.Entity;

namespace LibraryManagementSystem.Controllers
{
    public class StatisticsController : Controller
    {
        
        DB_LIBRARYEntities db = new DB_LIBRARYEntities();

        public ActionResult Index()
        {
            var books = db.BOOK_TABLE.ToList();
            var loanedBooks = db.ACTION_TABLE.ToList();
            var users = db.MEMBER_TABLE.ToList();
            ViewBag.bookNum = books.Count();
            ViewBag.loanedBookNum = loanedBooks.Count();
            ViewBag.userNum = users.Count();
            return View();
        }
    }
}