namespace BookCatalog.DAL.Repositories
{
    #region Namespaces
        using System;
        using System.Collections.Generic;
        using Entities;
        using Infrastructure.Business;
        using Infrastructure.Data.Repository;
    #endregion

    public class AutorsRepository : BaseRepository, IAutorsRepository<int, AutorEM>
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

        public AutorEM Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AutorEM> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(AutorEM entity)
        {
            throw new NotImplementedException();
        }

        public void Update(AutorEM entity)
        {
            throw new NotImplementedException();
        }
    }
}
