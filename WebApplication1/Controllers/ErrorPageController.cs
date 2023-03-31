using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Page404()
        {
            return View();
        }
    }
}
