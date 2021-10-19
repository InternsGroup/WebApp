using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryManagementSystem.Models.Entity;

namespace LibraryManagementSystem.Controllers
{
    public class CategoryController : Controller
    {
        //db nesnesi ile kütüphanedeki(veri tabanındaki) tablolara ve property'lere ulasabiliriz
        DB_LIBRARYEntities db = new DB_LIBRARYEntities();

        
        public ActionResult Index()
        {
             var values = db.CATEGORY_TABLE.ToList();
             return View(values);
           
        }

        //Index.cshtml sayfasinda add new category butonuna basilinca "get istegi" calisir ve httpget icin belirtilmis AddCategory() metodu calisir
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }


        //AddCategory.cshtml sayfasinda add category butonuna basilinca "post istegi" calisir ve httppost icin belirtilmis AddCategory() metodu calisir
        [HttpPost]
        public ActionResult AddCategory(CATEGORY_TABLE categoryObj)
        {
            db.CATEGORY_TABLE.Add(categoryObj);
            db.SaveChanges();
            return View();
        }

        //Index.cshtml sayfasinda delete butonuna basilinca Category/DeleteCategory/category.ID calistirilarak secilen alanin id si gonderiliyor
        //veri tabaninda bulunarak siliniyor redirect() ile sayfa guncelleniyor
        public ActionResult DeleteCategory(int id)
        {
            var category = db.CATEGORY_TABLE.Find(id);
            db.CATEGORY_TABLE.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //Index.cshtml sayfasinda kategori guncelle butonun basilinca cagirilan ActionResult
        public ActionResult GetCategory(int id)
        {
            var category = db.CATEGORY_TABLE.Find(id);
            return View("GetCategory", category);
        }

        public ActionResult UpdateCategory(CATEGORY_TABLE categoryObj)
        {
            var category = db.CATEGORY_TABLE.Find(categoryObj.ID);
            category.NAME = categoryObj.NAME;
            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }

}