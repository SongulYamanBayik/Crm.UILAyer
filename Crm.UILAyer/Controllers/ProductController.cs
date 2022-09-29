using Crm.BusinessLayer.Concrete;
using Crm.DataAccessLayer.EntityFramework;
using Crm.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crm.UILAyer.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EFProductDal());
        CategoryManager CategoryManager = new CategoryManager(new EFCategoryDal());
        public IActionResult Index()
        {
            var value = productManager.TGetListProductWithCategory();
            return View(value);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            List<SelectListItem> values = (from x in CategoryManager.TGetListAll()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            productManager.TInsert(product);
            return RedirectToAction("Index");
        }


    }
}
