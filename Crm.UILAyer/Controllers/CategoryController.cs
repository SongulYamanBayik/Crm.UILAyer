using Crm.BusinessLayer.Abstract;
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
    }
}
