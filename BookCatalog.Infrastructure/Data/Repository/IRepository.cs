using System;
using System.Collections.Generic;

namespace BookCatalog.Infrastructure.Data.Repository
{
    public interface IRepository<TKey,TEntity> : IDisposable
        where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(TKey id);
        long Insert(TEntity entity);
        bool Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
