using Microsoft.AspNetCore.Mvc;
using DesignPattern.Facade.DAL;
using DesignPattern.Facade.FacadePattern;

namespace DesignPattern.Facade.Controllers
{
    public class OrderController : Controller
    {
        Context context = new Context();
        
        [HttpGet]
        public IActionResult OrderDetailStart()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrderDetailStart(int customerID, int productID, int orderID, int productCount,
            decimal productPrice)
        {
            OrderFacade orderFacade = new OrderFacade();
            orderFacade.CompleteOrderDetail(customerID,productID, orderID, productCount, productPrice);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult OrderStart()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrderStart(int customerID)
        {
            OrderFacade orderFacade= new OrderFacade();
            orderFacade.CompleteOrder(customerID);
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
