﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryManagementSystem.Models.Entity;
namespace LibraryManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        DB_LIBRARYEntities db = new DB_LIBRARYEntities();
        // GET: Employee
        public ActionResult Index()
        {
            var values = db.EMPLOYEE_TABLE.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(EMPLOYEE_TABLE employeeObj)
        {
            /*  Input validation with data annotation
                if (!ModelState.IsValid)
                {
                    return View("AddEmployee");
                }   
            */
            db.EMPLOYEE_TABLE.Add(employeeObj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteEmployee(int id)
        {
            var employee = db.EMPLOYEE_TABLE.Find(id);
            db.EMPLOYEE_TABLE.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetEmployee(int id)
        {
            var employee = db.EMPLOYEE_TABLE.Find(id);
            return View("GetEmployee", employee);
        }

        public ActionResult UpdateEmployee(EMPLOYEE_TABLE employeeObj)
        {
            var employee = db.EMPLOYEE_TABLE.Find(employeeObj.ID);
            employee.EMPLOYEE = employeeObj.EMPLOYEE;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}