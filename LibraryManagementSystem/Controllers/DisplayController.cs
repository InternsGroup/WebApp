using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryManagementSystem.Models.Entity;

namespace LibraryManagementSystem.Controllers
{
    public class DisplayController : Controller
    {
        DB_LIBRARYEntities db = new DB_LIBRARYEntities();
        
        [HttpGet]
        public ActionResult Index()
        {
            var books = db.BOOK_TABLE.ToList();
            return View(books);
        }

       
        [HttpPost]
        public ActionResult Index(CONTACT_TABLE contactTableObj)
        {
            db.CONTACT_TABLE.Add(contactTableObj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}