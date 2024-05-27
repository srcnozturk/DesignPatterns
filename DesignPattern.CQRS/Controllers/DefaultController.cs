using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.CQRSPattern.Handlers;
using DesignPattern.CQRS.CQRSPattern.Queries;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.CQRS.Controllers
{
	public class DefaultController : Controller
	{
		private readonly GetProductQueryHandler _handler;
		private readonly CreateProductCommandHandler _createHandler;
		private readonly GetProductByIdQueryHandler _findByIdHandler;
		private readonly RemoveProductCommandHandler _removeByIdHandler;
		private readonly GetProductUpdateByIdQueryHandler _findByIdUpdateHandler;
		private readonly UpdateProductCommandHandler _updateByIdHandler;

        public DefaultController(GetProductQueryHandler handler, CreateProductCommandHandler createHandler, GetProductByIdQueryHandler findByIdHandler, RemoveProductCommandHandler removeByIdHandler, GetProductUpdateByIdQueryHandler findByIdUpdateHandler, UpdateProductCommandHandler updateByIdHandler)
        {
            _handler = handler;
            _createHandler = createHandler;
            _findByIdHandler = findByIdHandler;
            _removeByIdHandler = removeByIdHandler;
            _findByIdUpdateHandler = findByIdUpdateHandler;
            _updateByIdHandler = updateByIdHandler;
        }

        public IActionResult Index()
		{
			var values = _handler.Handle();

			return View(values);
		}
		[HttpGet]
		public IActionResult AddProduct() { return View(); }

		[HttpPost]
		public IActionResult AddProduct(CreateProductCommand cmd) 
		{
			_createHandler.Handle(cmd);
			return RedirectToAction("Index"); 
		}
		public IActionResult GetProduct(int id) 
		{ 
			var values = _findByIdHandler.Handle(new GetProductByIdQuery(id));
			return View(values);
		}

		public IActionResult DeleteProduct(int id)
		{
			_removeByIdHandler.Handle(new RemoveProductCommand(id));
			return RedirectToAction("Index");

		}
		[HttpGet]
		public IActionResult UpdateProduct(int id)
		{
			var values = _findByIdUpdateHandler.Handle(new GetProductUpdateByIdQuery(id));
			return View(values);
		}
		[HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand cmd)
        {
			_updateByIdHandler.Handle(cmd);
			return RedirectToAction("Index");
		}
	}
}
