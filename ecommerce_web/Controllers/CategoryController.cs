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

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "Name and display order cannot be the same");
            }

            // Only save new row if new category is valid according to its model
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                // Redirect to index after adding new row to categories table
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
