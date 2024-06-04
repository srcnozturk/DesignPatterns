using Microsoft.AspNetCore.Mvc;
using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();

        [HttpGet]
        public IActionResult AddNewProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("CustomerList");
        }

        public IActionResult ProductList()
        {
            var customers = context.Products.ToList();
            return View(customers);
        }
    }
}
