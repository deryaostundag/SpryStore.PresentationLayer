using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SpryStore.EntityLayer.Concrete;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

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
        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(AddRoleViewModel addRoleViewModel)
        {
            AppRole approle = new AppRole()
            {
                Name=addRoleViewModel.RoleName
            };
            await _roleManager.CreateAsync(approle);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteRole(int id)
        {
            var values=_roleManager.Roles.FirstOrDefault(y=>y.Id==id);
            await _roleManager.DeleteAsync(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateRole(int id)
        {
            var value=_roleManager.Roles.FirstOrDefault(x=>x.Id==id);
            UpdateRoleViewModel model = new UpdateRoleViewModel()
            {
                RoleId = value.Id,
                RoleName=value.Name
            };
            return View(value);

        }
        [HttpPost]
        public async Task<IActionResult> UpdateRole(UpdateRoleViewModel updateRoleViewModel)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == updateRoleViewModel.RoleId);
            value.Name = updateRoleViewModel.RoleName;
            await _roleManager.UpdateAsync(value);
            return RedirectToAction("Index");
        }
    }
}
