using LibraryManagementSystem.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class LendController : Controller
    {
        // GET: Lend
        DB_LIBRARYEntities db = new DB_LIBRARYEntities();
        public ActionResult Index()
        {
            var loanedBooksList = db.ACTION_TABLE.ToList();
            return View(loanedBooksList);
        }

        [HttpGet]
        public ActionResult Lend()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Lend(ACTION_TABLE lendObj)
        {
            db.ACTION_TABLE.Add(lendObj);
            var bookObj = db.BOOK_TABLE.Find(lendObj.BOOK);
            if (bookObj.STATUS == false)
            {
                //hata verdir kitap zaten birinde alamazsın diye
            }
            else
            {
                bookObj.STATUS = false;
                db.SaveChanges();
            }
            
            return RedirectToAction("Index");
        }

        public ActionResult ReturnBook(int id)
        {
            var lendObj = db.ACTION_TABLE.Find(id);
            lendObj.BOOK_TABLE.STATUS = true;
            
            return View("ReturnBook", lendObj);
        }

       public ActionResult UpdateReturnBook(ACTION_TABLE actionTableObj)
        {
            var actionObj = db.ACTION_TABLE.Find(actionTableObj.ID);
            actionObj.MEMBERRETURNDATE = actionTableObj.MEMBERRETURNDATE;
            actionObj.ACTIONSTATUS = true;
            actionObj.BOOK_TABLE.STATUS = true;

            //geri verilecek kitaplar listesinden kaldır
            db.ACTION_TABLE.Remove(actionObj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}