using System.Collections.Generic;
using BookCatalog.DAL.Tools;
using BookCatalog.Infrastructure.Context;
using BookCatalog.Infrastructure.Data.Repository;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;

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


        public TEntity Get(TKey id)
        {
            using (SqlConnection connection = new SqlConnection(Context.ConnectionString))
            {
                return connection.Get<TEntity>(id);
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(Context.ConnectionString))
            {
                return connection.GetAll<TEntity>();
            }
        }

        public long Insert(TEntity entity)
        {
            using (SqlConnection connection = new SqlConnection(Context.ConnectionString))
            {
                return connection.Insert(entity);
            }
        }

        public bool Update(TEntity entity)
        {
            using (SqlConnection connection = new SqlConnection(Context.ConnectionString))
            {
               return connection.Update(entity);
            }
        }

        public void Delete(TEntity entity)
        {
            using (SqlConnection connection = new SqlConnection(Context.ConnectionString))
            {
                connection.Delete(entity);
            }
        }

        public void Dispose()
        {
        }
    }
}
