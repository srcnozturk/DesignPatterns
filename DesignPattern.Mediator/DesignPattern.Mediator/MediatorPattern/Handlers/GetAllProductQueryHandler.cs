using DesignPattern.Mediator.MediatorPattern.Queries;
using DesignPattern.Mediator.MediatorPattern.Results;
using DesignPattern.Mediator.DAL;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetAllProductQueryResult>>
    {
        private readonly Context _context;

        public GetAllProductQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllProductQueryResult>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.Select(p => new GetAllProductQueryResult
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                ProductCategory = p.ProductCategory,
                ProductPrice = p.ProductPrice,
                ProductStock = p.ProductStock,
                ProductStockType = p.ProductStockType,
            }).AsNoTracking().ToListAsync();
        }
    }
}
