using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.Concrete;
using DesignPattern.DataAccessLayer.Repositories;
using DesignPattern.EntityLayer.Concrete;

namespace DesignPattern.DataAccessLayer.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>,ICustomerDal
    {
        public EfCustomerDal(Context context) : base(context)
        {
            
        }
    }
}
