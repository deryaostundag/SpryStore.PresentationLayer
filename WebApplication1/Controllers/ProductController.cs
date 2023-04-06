using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SpryStore.BusinessLayer.Abstract;
using SpryStore.EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Controllers
{
    
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategorySevice _categorySevice;

        public ProductController(IProductService productService, ICategorySevice categorySevice)
        {
            _productService = productService;
            _categorySevice = categorySevice;
        }

        public IActionResult Index()
        {
            var values = _productService.TGetProductsListWithCategory();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            List<SelectListItem> values = (from x in _categorySevice.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productService.TInsert(product);
            return RedirectToAction("Index");
        }
        public IActionResult GetLast4Products()
        {
            var values= _productService.TGetList();
            return View(values);
        }
    }
}
