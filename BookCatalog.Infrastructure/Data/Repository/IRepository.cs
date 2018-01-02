
namespace BookCatalog.Infrastructure.Data.Repository
{
    #region Namespaces
    using System;
    using System.Collections.Generic;
    #endregion


    public interface IRepository<TKey,TEntity> : IDisposable
        where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(TKey id);
        int Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TKey id);
    }
}
