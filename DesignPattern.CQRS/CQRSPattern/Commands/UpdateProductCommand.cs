namespace DesignPattern.CQRS.CQRSPattern.Commands
{
    public class UpdateProductCommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StockNumber { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
