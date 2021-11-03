using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryManagementSystem.Models.Entity;
using System.Web.Security;

namespace LibraryManagementSystem.Controllers
{
     

    public class LogInController : Controller
    {
        DB_LIBRARYEntities db = new DB_LIBRARYEntities();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(MEMBER_TABLE memberObj)
        {
            var username = memberObj.USERNAME;
            var password = memberObj.PASSWORD;
            var userExist = db.MEMBER_TABLE.First(x => x.PASSWORD == password &&  x.USERNAME == username);
            if(userExist != null)
            {
               
            }

            return View("/Panel/Index");
        }
    }
}