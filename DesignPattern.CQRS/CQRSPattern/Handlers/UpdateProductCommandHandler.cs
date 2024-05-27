using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateProductCommand cmd)
        {
            var values= _context.Products.Find(cmd.Id);
            values.Name = cmd.Name;
            values.Description = cmd.Description;
            values.Price = cmd.Price;
            values.StockNumber = cmd.StockNumber;
            _context.SaveChanges();
        }
    }
}
