using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Areas.Catalog.Controllers
{
    [Area("Catalog")]
    public class AboutController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialAboutCover()
        {
            return PartialView();
        }
        public PartialViewResult PartialAboutWhatWeDo()
        {
            return PartialView();
        }
    }
}
