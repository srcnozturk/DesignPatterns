using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
	public class CreateProductCommandHandler
	{
		private readonly Context _context;

		public CreateProductCommandHandler(Context context)
		{
			_context = context;
		}

		public void Handle(CreateProductCommand cmd)
		{
			_context.Products.Add(new Product
			{
				Description = cmd.Description,
				Name = cmd.Name,
				Price = cmd.Price,
				Status = true,
				StockNumber = cmd.StockNumber,
			});
			_context.SaveChanges();
		}
	}
}
