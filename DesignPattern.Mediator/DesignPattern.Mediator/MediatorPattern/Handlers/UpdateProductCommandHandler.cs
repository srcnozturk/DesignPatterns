using DesignPattern.Mediator.MediatorPattern.Commands;
using DesignPattern.Mediator.DAL;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var values                      = _context.Products.FindAsync(request.ProductID);
            values.Result.ProductName       = request.ProductName;
            values.Result.ProductStock      = request.ProductStock;
            values.Result.ProductPrice      = request.ProductPrice;
            values.Result.ProductStockType  = request.ProductStockType;
            values.Result.ProductCategory   = request.ProductCategory;
            await _context.SaveChangesAsync();
        }
    }
}
