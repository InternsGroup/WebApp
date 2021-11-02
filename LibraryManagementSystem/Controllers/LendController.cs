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
            var memberObj = db.MEMBER_TABLE.Find(lendObj.MEMBER);
            var employeeObj = db.EMPLOYEE_TABLE.Find(lendObj.EMPLOYEE);
            
            if (bookObj == null)
            {
                ViewBag.Message = "Enter valid book ID.";
                return View("Lend");
            }
            else if (bookObj.STATUS == false)
            {
                ViewBag.Message = "Book is already loaned to another member.";
                return View("Lend");
            }
            else if (memberObj == null)
            {
                ViewBag.Message = "Enter valid member ID.";
                return View("Lend");
            }
            else if (employeeObj == null)
            {
                ViewBag.Message = "Enter valid employee ID.";
                return View("Lend");
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