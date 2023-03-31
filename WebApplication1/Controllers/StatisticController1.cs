using Microsoft.AspNetCore.Mvc;
using SpryStore.DataAccessLayer.Concrete;
using System.Linq;

namespace WebApplication1.Controllers
{
    public class StatisticController1 : Controller
    {
        public IActionResult Index()
        {
            Context context = new Context();
            ViewBag.categoryCount = context.Categories.Count();
            ViewBag.productCount =context.Products.Count();
            ViewBag.productCountByElektronik = context.Products.Where(x => x.Category.CategoryName == "Elektronik").Count();
            ViewBag.priceLower5000 = context.Products.Where(x => x.Price <= 5000).Count();
            ViewBag.avgPrice = context.Products.Average(x => x.Price);
            return View();
        }
    }
}
