using Microsoft.AspNetCore.Mvc;
using DesignPattern.Composite.DAL;
using DesignPattern.Composite.CompositePattern;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Composite.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context _context;

        public IActionResult Index()
        {
            var categories  =_context.Categories.Include(p=> p.Products).ToList();
            var values = Rekursive(categories, new Category { CategoryName = "FirstCategory", CategoryID = 0 },
                new ProductComposite(0,"FirstComposite"));
            ViewBag.v = values;
            return View();
        }

        public ProductComposite Rekursive(List<Category> categories,Category firstCategory,ProductComposite firstComposite,
            ProductComposite leaf=null)
        {
            categories.Where(x => x.UpperCategoryID == firstCategory.CategoryID).ToList().ForEach(y =>
            {
                var productComposite = new ProductComposite(y.CategoryID, y.CategoryName);

                y.Products.ToList().ForEach(z =>
                {
                    productComposite.Add(new ProductComponent(z.ProductID, z.ProductName));
                });
                if (leaf is not null)
                {
                    leaf.Add(productComposite);
                }
                else
                {
                    firstComposite.Add(productComposite);
                }
                Rekursive(categories, y, firstComposite, productComposite);
            });
            return firstComposite;
        }

    }
}
