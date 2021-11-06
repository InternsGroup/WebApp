using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryManagementSystem.Models.Entity;

namespace LibraryManagementSystem.Controllers
{
    public class RegisterController : Controller
    {
        DB_LIBRARYEntities db = new DB_LIBRARYEntities();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(MEMBER_TABLE userObj)
        {
            db.MEMBER_TABLE.Add(userObj);
            db.SaveChanges();
            return RedirectToAction("Index","LogIn");
        }
    }
}