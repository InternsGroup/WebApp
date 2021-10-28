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
            db.SaveChanges();
            return RedirectToAction("Lend");
        }
    }
}