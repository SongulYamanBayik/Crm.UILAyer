using Crm.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crm.UILAyer.ViewComponents.Dashboard
{
    public class Chart: ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.P1 = context.Products.Where(x => x.ProductID == 1).Select(y => y.ProductStock).FirstOrDefault();
            ViewBag.P2 = context.Products.Where(x => x.ProductID == 2).Select(y => y.ProductStock).FirstOrDefault();
            ViewBag.P3 = context.Products.Where(x => x.ProductID == 3).Select(y => y.ProductStock).FirstOrDefault();
            ViewBag.P4 = context.Products.Where(x => x.ProductID == 8).Select(y => y.ProductStock).FirstOrDefault();
            ViewBag.P5 = context.Products.Where(x => x.ProductID == 9).Select(y => y.ProductStock).FirstOrDefault();
            return View();
        }
    }
}
