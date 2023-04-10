using Microsoft.AspNetCore.Mvc;
using SpryStore.BusinessLayer.Abstract;

namespace WebApplication1.ViewComponents
{
    public class _MapContact : ViewComponent
    {
        private readonly IAddressService _addressService;

        public _MapContact(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public IViewComponentResult Invoke()
        {
            var values=_addressService.TGetList();
            return View(values);
        }
    }
}
