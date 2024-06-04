using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadePattern
{
    public class ProductStock
    {
        Context context = new Context();

        public void StockDecrease(int id, int amount)
        {
            var getProduct = context.Products.Find(id);
            getProduct.ProductStock -= amount;
            context.SaveChanges();
        }
    }
}
