namespace BookCatalog.Infrastructure.Data.Repository
{
    public interface IAutorsRepository<TKey, TEntity> : IRepository<TKey, TEntity> where TEntity : class
    {
    }
}
