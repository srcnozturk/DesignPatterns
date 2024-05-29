using RepositoryDesignPattern.EntityLayer.Concrete;
using System.Collections.Generic;

namespace RepositoryDesignPattern.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> ProductListWithCategory();
    }
}
