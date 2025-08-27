using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            ViewBag.Message = "This is ProductList page of ProductController";
            return View();
        }

        public IActionResult Details(int id = 1)
        {
            ViewBag.Message = $"This is Details of Item ID = {id}";
            return View();
        }
    }
}
