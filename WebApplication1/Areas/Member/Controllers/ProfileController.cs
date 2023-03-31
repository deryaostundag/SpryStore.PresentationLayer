using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SpryStore.EntityLayer.Concrete;
using System.Security.AccessControl;
using System.Threading.Tasks;
using WebApplication1.Areas.Member.Models;

namespace WebApplication1.Areas.Member.Controllers
{
    [Area("Member")]
    public class ProfileController : Controller
    {
        
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel=new UserEditViewModel();
            userEditViewModel.Name = values.Name;
            userEditViewModel.Surname = values.Surname;
            userEditViewModel.City=values.City;
            userEditViewModel.Mail=values.Email;
            userEditViewModel.Phone=values.PhoneNumber;
            ViewBag.name = values.Name;
            ViewBag.surname = values.Surname;
            return View(userEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEditViewModel)
        {
            var values=await _userManager.FindByNameAsync(User.Identity.Name);
            values.Name = userEditViewModel.Name;
            values.Surname = userEditViewModel.Surname;
            values.City = userEditViewModel.City;
            values.PhoneNumber = userEditViewModel.Phone;
            values.Email = userEditViewModel.Mail;
            await _userManager.UpdateAsync(values);
            return View();
        }
    }
}
