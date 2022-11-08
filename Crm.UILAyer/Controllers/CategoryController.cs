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
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListCategory()
        {
            var value = JsonConvert.SerializeObject(_categoryService.TGetListAll());
            return Json(value);
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _categoryService.TInsert(category);
            var values = JsonConvert.SerializeObject(category);
            return Json(values);
        }

        public IActionResult GetByID(int categoryid)
        {
            var v = _categoryService.TGetByID(categoryid);
            var values = JsonConvert.SerializeObject(v);
            return Json(values);
        }

        public IActionResult DeleteCategory(int id)
        {
            var v = _categoryService.TGetByID(id);
            _categoryService.TDelete(v);
            return NoContent();
        }
    }
}
