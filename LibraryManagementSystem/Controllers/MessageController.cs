﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryManagementSystem.Models.Entity;

namespace LibraryManagementSystem.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        DB_LIBRARYEntities db = new DB_LIBRARYEntities();
        public ActionResult Index()
        {
            //session userName uzerinden yaptigimiz icin sender, receiver bilgisi email yerine userName yaptim
            //isterseniz email ile degistirebiliriz
            var userName = (string)Session["Username"].ToString();
            var messages = db.MESSAGE_TABLE.Where(x => x.RECEIVER == userName.ToString()).ToList();
            return View(messages);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(MESSAGE_TABLE messageObj)
        {
            var userName = (string)Session["Username"].ToString();
            messageObj.SENDER = userName.ToString();
            messageObj.DATE = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.MESSAGE_TABLE.Add(messageObj);
            db.SaveChanges();
            return View();
        }
    }
}