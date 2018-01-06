using System;
using BookCatalog.Infrastructure.Injection;
using Unity;

namespace BookCatalog.Initializer
{
    public class UnitySetup
    {
        static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            IUnityContainer container = new UnityContainer();
            RegisterTypes(container);
            return container;
        }); 

        private static void RegisterTypes(IUnityContainer container)
        {
            UnityDependencyRegister.RegisterDependencyTypes(container);
        }

        public static IServiceProviderFactory CreateServiceProviderFactory()
        {
            return new ServiceProviderFactory(container.Value);
        }
    }
}
