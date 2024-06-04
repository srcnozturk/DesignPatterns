using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.Concrete;
using System.Linq;

namespace DesignPattern.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            _context = context;
        }

        public void Delete(T t)
        {
           _context.Remove(t);
        }

        public T GetByID(int id)
        {
           return _context.Set<T>().Find(id);
        }

        public System.Collections.Generic.List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            _context.Add(t);
        }

        public void MultiUpdate(System.Collections.Generic.List<T> t)
        {
          _context.UpdateRange(t);
        }

        public void Update(T t)
        {
           _context.Update(t);
        }
    }
}
