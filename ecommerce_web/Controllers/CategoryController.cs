using ecommerce_web.Data;
using ecommerce_web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce_web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            // Get database object from dependency injection
            _db = db;
        }

        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();

            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
