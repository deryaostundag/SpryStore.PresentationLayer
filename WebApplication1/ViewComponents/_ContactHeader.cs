using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents
{
    public class _ContactHeader:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
