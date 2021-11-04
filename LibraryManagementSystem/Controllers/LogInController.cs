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
            var userInfo = db.MEMBER_TABLE.FirstOrDefault(x => x.PASSWORD == password && x.USERNAME == username);
            if (userInfo != null)
            {
                FormsAuthentication.SetAuthCookie(userInfo.USERNAME, false);
                Session["Username"] = userInfo.USERNAME.ToString();
                //Session["Email"] = userInfo.EMAIL.ToString();
                //TempData["Id"] = userInfo.ID.ToString();
                //TempData["Name"] = userInfo.NAME.ToString();
                //TempData["Surname"] = userInfo.SURNAME.ToString();
                //TempData["Password"] = userInfo.PASSWORD.ToString();
                return RedirectToAction("Index", "Panel");
            }
            else
            {
                return View();
            }
        }
    }
}