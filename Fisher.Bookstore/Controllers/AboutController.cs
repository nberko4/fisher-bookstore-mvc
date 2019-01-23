using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the About controllers index action");
        }
        public IActionResult history()
        {
            return Content("This is the About controllers history action");
        }
        public IActionResult location()
        {
            return Content("This is the About controllers location action");
        }
    }
}