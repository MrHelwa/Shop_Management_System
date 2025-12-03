using Lab8_Part2_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Lab8_Part2_MVC.Controllers
{
    public class ProductController : Controller
    {
        ShopDbContext context = new ShopDbContext();

        // GET: Product
        public IActionResult Index()
        {
            var products = context.Products.Include(p => p.Customer).ToList();
            return View(products);
        }

        // GET: Product/Details/5
        public IActionResult Details(int id)
        {
            var product = context.Products
                .Include(p => p.Customer)
                .FirstOrDefault(p => p.ID == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Product/Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Customers = new SelectList(context.Customers.ToList(), "ID", "Name");
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                context.Products.Add(product);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Customers = new SelectList(context.Customers.ToList(), "ID", "Name");
            return View(product);
        }

        // GET: Product/Edit/5
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = context.Products.FirstOrDefault(p => p.ID == id);

            if (product == null)
            {
                return NotFound();
            }

            ViewBag.Customers = new SelectList(context.Customers.ToList(), "ID", "Name");
            return View(product);
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                context.Products.Update(product);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Customers = new SelectList(context.Customers.ToList(), "ID", "Name");
            return View(product);
        }

        // GET: Product/Delete/5
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = context.Products
                .Include(p => p.Customer)
                .FirstOrDefault(p => p.ID == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = context.Products.FirstOrDefault(p => p.ID == id);

            if (product != null)
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}