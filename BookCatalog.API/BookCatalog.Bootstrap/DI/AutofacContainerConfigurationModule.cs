using Autofac;
using BookCatalog.Service;

namespace BookCatalog.Bootstrap.DI
{
    public class AutofacContainerConfigurationModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            RegisterServices(builder);
        }

        public void RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterType<DataProvider>().As<IDataProvider>();
        }
    }
}
