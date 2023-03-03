namespace Natasha_SportStore.Models
{
	public interface IStoreRepository
	{
		IQueryable<Product> Products { get; }
	}
}
