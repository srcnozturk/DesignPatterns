namespace DesignPattern.CQRS.DAL
{
	public class Product
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public int StockNumber { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
