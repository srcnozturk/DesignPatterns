using DesignPattern.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options): base(options)
        {
              
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Process> Processes { get; set; }
    }
}
