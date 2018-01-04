namespace BookCatalog.DAL.Repositories
{
    #region Namespaces
    using System;
    using System.Collections.Generic;
    using Entities;
    using Infrastructure.Business;
    using Infrastructure.Data.Repository;
    using System.Data;
    using System.Data.SqlClient;
    using DapperExtensions;
    #endregion

    public class AutorsRepository : BaseRepository, IAutorsRepository<int, AuthorEM>
    {
        #region Constructors
        public AutorsRepository(IBusinessContext context) : base(context){}
        #endregion

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public AuthorEM Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AuthorEM> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(AuthorEM entity)
        {
            throw new NotImplementedException();
        }

        public void Update(AuthorEM entity)
        {
            throw new NotImplementedException();
        }
    }
}
