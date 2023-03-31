using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SpryStore.EntityLayer.Concrete;
using System.Linq;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public UserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }
    }
}
