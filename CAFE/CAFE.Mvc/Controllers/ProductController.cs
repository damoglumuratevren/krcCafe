
using CAFE.Business.Concrete.CategoryMn;
using CAFE.Business.Concrete.ProductMn;
using CAFE.Business.ValidationRules.ProductVr;
using CAFE.DataAxcess.EntityFremework.CategoryEf;
using CAFE.DataAxcess.EntityFremework.ProductEf;
using CAFE.Entity.Concrete.ProductEn;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CAFE.Mvc.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EFProductDal());
        CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
        // GET: Product
        public ActionResult Index()
        {
            var products = productManager.GetList();
            return View(products);
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            List<SelectListItem> category = (from x in categoryManager.GetList()
                                             select new SelectListItem
                                             {
                                                 Text=x.CategoryName,
                                                 Value=x.CategoryId.ToString()
                                             }).ToList();
            ViewBag.cat = category;
            return View();
        }
        public ActionResult DeleteProduct(int id)
        {
            var product = productManager.GetById(id);
            productManager.deleteProduct(product);
            return RedirectToAction("Index");

        }

        [HttpPost]
        public ActionResult AddProduct(Product p)
        {
            ProductValidation pv = new ProductValidation();
            ValidationResult validationResult = pv.Validate(p);
            if (validationResult.IsValid)
            {
                productManager.addProduct(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}