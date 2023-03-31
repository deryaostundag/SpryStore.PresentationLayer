using Microsoft.AspNetCore.Mvc;
using SpryStore.BusinessLayer.Abstract;
using System.Security.AccessControl;

namespace WebApplication1.Areas.Catalog.Controllers
{
    [Area("Catalog")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        public IActionResult Index()
        {
            var values = _productService.TGetProductsListWithCategory();
            return View(values);
        }
    }
}
