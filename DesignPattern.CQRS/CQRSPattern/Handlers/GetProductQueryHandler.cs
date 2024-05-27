using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
	public class GetProductQueryHandler
	{
		private readonly Context _context;

		public GetProductQueryHandler(Context context)
		{
			_context = context;
		}
		public List<GetProductQueryResult> Handle()
		{
			var values=_context.Products.Select(x=> new GetProductQueryResult
			{
				Id = x.Id,
				Price = x.Price,
				ProductName= x.Name,
				StockNumber = x.StockNumber,

			}).ToList();
			return values;
		}
	}
}
