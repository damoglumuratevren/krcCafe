using CAFE.Business.Concrete.CategoryMn;
using CAFE.Business.ValidationRules.CategoryVr;
using CAFE.DataAxcess.EntityFremework.CategoryEf;
using CAFE.Entity.Concrete.CategoryEn;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CAFE.Mvc.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());

        // GET: AdminCategory
        public ActionResult Index()
        {

            var category = categoryManager.GetList();
            return View(categoryManager);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var category = categoryManager.GetById(id);
            categoryManager.CategoryUpdate(category);
            return View(category);
        }


        public ActionResult DeleteCategory(int id)
        {
            var category = categoryManager.GetById(id);
            categoryManager.CategoryDelete(category);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult AddCategory(Category c)
        {
            CategoryValidation cv = new CategoryValidation();
            ValidationResult result = cv.Validate(c);
            Category category = new Category();
            //category.CategoryName = c.CategoryName;
            //category.CreatedDtm = DateTime.Now;
            if (result.IsValid)
            {
                categoryManager.CategoryAdd(c);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}