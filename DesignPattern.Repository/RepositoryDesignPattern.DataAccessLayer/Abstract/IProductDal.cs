using RepositoryDesignPattern.EntityLayer.Concrete;

namespace RepositoryDesignPattern.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
    }
}
