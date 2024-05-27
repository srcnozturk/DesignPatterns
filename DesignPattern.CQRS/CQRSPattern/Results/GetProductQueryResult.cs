namespace DesignPattern.CQRS.CQRSPattern.Results
{
	public class GetProductQueryResult
	{
        public int Id { get; set; }
        public int StockNumber { get; set; }
        public decimal Price { get; set; }
        public string ProductName { get; set; }
    }
}
