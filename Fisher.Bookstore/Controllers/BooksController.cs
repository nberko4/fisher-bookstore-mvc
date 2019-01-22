using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the Book controllers index action");
        }
        public IActionResult New()
        {
            return Content("This is the Book controllers New action");
        }
        public IActionResult Best()
        {
            return Content("This is the Book controllers Best action");
        }
    }
}