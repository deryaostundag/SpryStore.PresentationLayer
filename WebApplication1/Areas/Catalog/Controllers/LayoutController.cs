using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Areas.Catalog.Controllers
{
    [Area("Catalog")]
    public class LayoutController : Controller
    {
        public IActionResult _CatologLayout()
        {
            return View();
        }
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        public PartialViewResult NavbarHeader()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}
