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
            return View();
        }

        public ActionResult Lend()
        {
            return View();
        }


        //AddCategory.cshtml sayfasinda add category butonuna basilinca "post istegi" calisir ve httppost icin belirtilmis AddCategory() metodu calisir
        [HttpPost]
        public ActionResult AddLending(ACTION_TABLE lendObj)
        {
            db.ACTION_TABLE.Add(lendObj);
            db.SaveChanges();
            return RedirectToAction("Lend");
        }
    }
}