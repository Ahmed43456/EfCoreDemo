using EfCoreDemo.Data;
using Microsoft.AspNetCore.Mvc;

namespace EfCoreDemo.Controllers
{
    public class ProductControllerr : Controller
    {
        private readonly ApplicationDbContext db;
        public ProductControllerr(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var model = db.Products;
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
       [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = db.Products.Find(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id, Product model)        {
            if (!ModelState.IsValid)
            {
                db.Products.Update(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            var model = db.Products.Find(id);
            if (model == null)
            {
                return NotFound();

            }
            return View(model);        }
        [HttpPost]
        public IActionResult DeleteConfiamtion(int id)
        {
            var model = db.Products.Find(id);
            if (model == null)
            {
                return NotFound();
            }
            db.Products.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
