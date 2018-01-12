using System.Collections.Generic;
using BookCatalog.Infrastructure.Context;
using BookCatalog.Infrastructure.Data.Repository;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;

namespace BookCatalog.DAL.Repositories
{
    public abstract class DapperBaseRepository<TKey, TEntity> : IRepository<TKey, TEntity> where TEntity : class
    {
        protected IRootContext Context { get; set; }

        #region Constructors

        public DapperBaseRepository(IRootContext context)
        {
            Context = context;
        }
        #endregion


        public virtual TEntity Get(TKey id)
        {
            using (SqlConnection connection = new SqlConnection(Context.ConnectionString))
            {
                return connection.Get<TEntity>(id);
            }
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(Context.ConnectionString))
            {
                return connection.GetAll<TEntity>();
            }
        }

        public virtual long Insert(TEntity entity)
        {
            using (SqlConnection connection = new SqlConnection(Context.ConnectionString))
            {
                return connection.Insert(entity);
            }
        }

        public virtual bool Update(TEntity entity)
        {
            using (SqlConnection connection = new SqlConnection(Context.ConnectionString))
            {
               return connection.Update(entity);
            }
        }

        public virtual void Delete(TEntity entity)
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
