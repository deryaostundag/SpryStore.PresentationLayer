using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplication1.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            Random rnd=new Random();
            int number=rnd.Next(0,100);
            ViewBag.n=number;
            return View();
        }
    }
}
