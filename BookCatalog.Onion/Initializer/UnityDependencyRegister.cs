using BookCatalog.Infrastructure.Business;
using BookCatalog.Infrastructure.Context;
using BookCatalog.Business.Author;
using BookCatalog.Business.Book;
using BookCatalog.Business.Tools;
using BookCatalog.DAL.Repositories;
using BookCatalog.Infrastructure.Data.Repository;
using Unity;

namespace BookCatalog.Initializer
{
    public class UnityDependencyRegister
    {
        private static IUnityContainer _container;

        public static void RegisterDependencyTypes(IUnityContainer container)
        {
            _container = container;

            RegisterContexts();
            RegisterBusinessTypes();
            RegisterDataTypes();
        }

        private static void RegisterContexts()
        {
            _container.RegisterType<IWebContext, WebContext>();
            _container.RegisterType<IBusinessContext, BusinessContext>();
        }

        private static void RegisterBusinessTypes()
        {
            _container.RegisterType<IAuthorDM, AuthorDM>();   
            _container.RegisterType<IBookDM, BookDM>();
        }

        private static void RegisterDataTypes()
        {
            _container.RegisterType<IBookRepository, BookRepository>();
            _container.RegisterType<IAuthorRepository, AuthorRepository>();
        }
    }
}
