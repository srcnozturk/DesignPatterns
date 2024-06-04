using RepositoryDesignPattern.EntityLayer.Concrete;
using System.Collections.Generic;

namespace RepositoryDesignPattern.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TProductListWithCategory();
    }
}
