using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SpryStore.EntityLayer.Concrete;
using System.Linq;

namespace WebApplication1.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }
    }
}
