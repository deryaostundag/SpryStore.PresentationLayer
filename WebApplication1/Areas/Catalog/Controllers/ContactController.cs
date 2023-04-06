using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Areas.Catalog.Controllers
{
    [Area("Catalog")]
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
