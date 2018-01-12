using BookCatalog.Infrastructure;
using BookCatalog.Infrastructure.Context;
using BookCatalog.Infrastructure.Injection;

namespace BookCatalog.Business.Tools
{
    public class BusinessContext : IBusinessContext
    {
        #region Constructor
        public BusinessContext(IRootContext context)
        {
            RootContext = context;
        }
        #endregion


        public IServiceProviderFactory Factory => RootContext.Factory; 

        public IRootContext RootContext { get; set; }

        public IMapperService Mapper => RootContext.Mapper;
    }
}
