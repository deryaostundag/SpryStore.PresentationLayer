using Microsoft.AspNetCore.Mvc;
using SpryStore.DataAccessLayer.Concrete;
using System.Linq;

namespace SpryStore.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Customers.ToList();
            return View(values);
        }
    }
}
