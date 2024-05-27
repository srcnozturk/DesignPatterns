namespace DesignPattern.CQRS.CQRSPattern.Results
{
    public class GetProductByIdProductResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StockNumber { get; set; }
        public decimal Price { get; set; }
    }
}
