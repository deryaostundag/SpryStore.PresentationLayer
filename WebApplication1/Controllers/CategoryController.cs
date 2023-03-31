using Microsoft.AspNetCore.Mvc;
using SpryStore.BusinessLayer.Abstract;
using SpryStore.EntityLayer.Concrete;

namespace WebApplication1.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategorySevice _categorySevice;

        public CategoryController(ICategorySevice categorySevice)
        {
            _categorySevice = categorySevice;
        }

        public IActionResult Index()
        {
            var values = _categorySevice.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _categorySevice.TInsert(category);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCategory(int id)
        {
            var value= _categorySevice.TGetByID(id);
            _categorySevice.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var value = _categorySevice.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            _categorySevice.TUpdate(category);
            return RedirectToAction("Index");
        }
    }
}
