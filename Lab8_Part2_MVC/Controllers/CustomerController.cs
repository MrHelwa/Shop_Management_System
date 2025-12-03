using Lab8_Part2_MVC.Models;
using Lab8_Part2_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab8_Part2_MVC.Controllers
{
    public class CustomerController : Controller
    {
        ShopDbContext context = new ShopDbContext();

        // GET: Customer
        public IActionResult Index()
        {
            var customers = context.Customers.ToList();
            return View(customers);
        }

        // GET: Customer/Details/5 - Using ViewModel
        public IActionResult Details(int id)
        {
            var customer = context.Customers
                .Include(c => c.Products)
                .FirstOrDefault(c => c.ID == id);

            if (customer == null)
            {
                return NotFound();
            }

            // Create ViewModel
            var viewModel = new Product_Cust_ViewModel
            {
                CustomerID = customer.ID,
                CustomerName = customer.Name,
                CustomerEmail = customer.Email,
                CustomerPhone = customer.PhoneNum,
                Products = customer.Products?.ToList() ?? new List<Product>()
            };

            return View(viewModel);
        }

        // GET: Customer/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                context.Customers.Add(customer);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // GET: Customer/Edit/5
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var customer = context.Customers.FirstOrDefault(c => c.ID == id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                context.Customers.Update(customer);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // GET: Customer/Delete/5
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var customer = context.Customers
                .Include(c => c.Products)
                .FirstOrDefault(c => c.ID == id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customer/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var customer = context.Customers.FirstOrDefault(c => c.ID == id);

            if (customer != null)
            {
                context.Customers.Remove(customer);
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}