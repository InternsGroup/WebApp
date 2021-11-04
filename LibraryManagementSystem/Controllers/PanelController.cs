using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryManagementSystem.Models.Entity;

namespace LibraryManagementSystem.Controllers
{
    public class PanelController : Controller
    {
        DB_LIBRARYEntities db = new DB_LIBRARYEntities();
        // GET: Panel
        [HttpGet]
        [Authorize]
        public ActionResult Index()
        {
            var user = (string)Session["Username"];
            var values = db.MEMBER_TABLE.FirstOrDefault(x => x.USERNAME == user);
            ViewBag.Message = null;
            return View(values);
        }
        [HttpPost]
        public ActionResult Index(MEMBER_TABLE memberObj)
        {
            var user = (string)Session["Username"];
            var member = db.MEMBER_TABLE.FirstOrDefault(x => x.USERNAME == user);
            member.NAME = memberObj.NAME;
            member.SURNAME = memberObj.SURNAME;
            member.PASSWORD = memberObj.PASSWORD;
            member.PHOTO = memberObj.PHOTO;
            ViewBag.Message = "Info successfully updated.";
            db.SaveChanges();
            return View(member);
        }
    }
}