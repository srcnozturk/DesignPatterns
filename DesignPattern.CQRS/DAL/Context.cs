using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.DAL
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=SERCAN; initial catalog=CQRSDPDb; integrated security=true");
		}
		public DbSet<Product> Products { get; set; }
	}
}
