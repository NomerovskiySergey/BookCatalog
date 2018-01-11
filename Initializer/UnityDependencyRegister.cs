using BookCatalog.Infrastructure.Business;
using BookCatalog.Infrastructure.Context;
using BookCatalog.Business.Author;
using BookCatalog.Business.Book;
using BookCatalog.Business.Tools;
using BookCatalog.DAL.Repositories;
using BookCatalog.DAL.Tools;
using BookCatalog.Infrastructure.Data.Repository;
using Unity;
using Unity.Injection;

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
            _container.RegisterType<IDataContext, DataContext>();
        }

        private static void RegisterBusinessTypes()
        {
            _container.RegisterType<IAuthorDM, AuthorDM>(new InjectionConstructor(typeof(IBusinessContext)));
            _container.RegisterType<IAuthorDM, AuthorDM>(new InjectionConstructor(typeof(IWebContext)));
   
            _container.RegisterType<IBookDM, BookDM>(new InjectionConstructor(typeof(IBusinessContext)));
            _container.RegisterType<IBookDM, BookDM>(new InjectionConstructor(typeof(IWebContext)));
        }

        private static void RegisterDataTypes()
        {
            _container.RegisterType<IBookRepository, BookRepository>(new InjectionConstructor(typeof(IBusinessContext)));
            _container.RegisterType<IBookRepository, BookRepository>(new InjectionConstructor(typeof(IDataContext)));

            _container.RegisterType<IAuthorRepository, AuthorRepository>(new InjectionConstructor(typeof(IBusinessContext)));
            _container.RegisterType<IAuthorRepository, AuthorRepository>(new InjectionConstructor(typeof(IDataContext)));
        }
    }
}
