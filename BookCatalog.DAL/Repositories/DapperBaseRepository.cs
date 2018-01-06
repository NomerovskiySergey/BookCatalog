using System;
using System.Collections.Generic;
using BookCatalog.DAL.Tools;
using BookCatalog.Infrastructure.Context;
using BookCatalog.Infrastructure.Data.Repository;

namespace BookCatalog.DAL.Repositories
{
    public class DapperBaseRepository<TKey, TEntity> : IRepository<TKey, TEntity> where TEntity : class
    {
        private IDataContext _context;

        #region Constructors
        public DapperBaseRepository(IBusinessContext context)
        {
            _context = new DataContext(context);
        }

        public DapperBaseRepository(IDataContext context)
        {
            _context = context;
        }
        #endregion

        protected IDataContext Context => _context;

        public void Delete(TKey id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public TEntity Get(TKey id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
