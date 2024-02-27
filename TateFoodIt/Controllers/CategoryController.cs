using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TateFoodIt.Context;
using TateFoodIt.Entities;

namespace TateFoodIt.Controllers
{
    public class CategoryController : Controller
    {
        TasteContext context=new TasteContext();
        public ActionResult CategoryList()
        {
            var values=context.Categories.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return View("CategoryList");
        }
    }
}