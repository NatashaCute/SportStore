namespace Natasha_SportStore.Models
{
	public class EFStoreRepository : IStoreRepository
	{
		private StoreDbContext context;

		public EFStoreRepository(StoreDbContext ctx)
		{
			context = ctx;
		}

		IQueryable<Product> IStoreRepository.Products => context.Products;
	}
}
