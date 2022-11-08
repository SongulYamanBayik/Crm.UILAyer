using Crm.BusinessLayer.Abstract;
using Crm.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crm.UILAyer.Controllers
{
    public class Category2Controller : Controller
    {
        private readonly ICategoryService _categoryService;

        public Category2Controller(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult getCategoryList()
        {
            var value = JsonConvert.SerializeObject(_categoryService.TGetListAll());
            return Json(value);
        }


        public JsonResult updateCategory(int categoryid, string categoryName)
        {
            var model = _categoryService.TGetByID(categoryid);
            model.CategoryName = categoryName;

            _categoryService.TUpdate(model);

            return Json(true);
        }

        public JsonResult deleteCategory(int categoryid)
        {
            var model = _categoryService.TGetByID(categoryid);

            _categoryService.TDelete(model);

            return Json(true);
        }
        public JsonResult addCategory(string categoryName)
        {
            Category category = new Category();
            category.CategoryName = categoryName;

            _categoryService.TInsert(category);

            return Json(true);

        }

    }
}