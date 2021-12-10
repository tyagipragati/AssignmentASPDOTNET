using Microsoft.AspNetCore.Mvc;
using product.Data;
using product.Models;

namespace product.Controllers
{
    public class GasMeterController : Controller
    {
        private readonly ApplicationDbContext _db;
        public GasMeterController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            IEnumerable<Product> objProductList = _db.liberty;
            return View(objProductList);
        }
        public IActionResult Create()
        {
            
            return View();
        }
    }
}
