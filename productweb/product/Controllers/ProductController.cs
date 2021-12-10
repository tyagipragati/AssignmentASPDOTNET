using Microsoft.AspNetCore.Mvc;

namespace product.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
