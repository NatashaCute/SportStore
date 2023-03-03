using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Natasha_SportStore.Models
{
	public class StoreDbContext : DbContext
	{
		public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options){ }


		public DbSet<Product> Products => Set<Product>();
		
		
	}
}
