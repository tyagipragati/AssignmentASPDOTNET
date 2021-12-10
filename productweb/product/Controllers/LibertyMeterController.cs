using Microsoft.AspNetCore.Mvc;
using product.Data;
using product.Models;

namespace product.Controllers
{
    public class LibertyMeterController : Controller
    {

        private readonly ApplicationDbContext _db;
        public LibertyMeterController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            IEnumerable<Product> objProductList = _db.liberty;
            return View(objProductList);
        }
        //GET
        public IActionResult Create()
        {
            
            return View();
        }
        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product obj)
        {
            _db.liberty.Add(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
