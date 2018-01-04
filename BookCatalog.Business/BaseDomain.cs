namespace BookCatalog.Business
{
    #region
    using Infrastructure.Business;
    using Infrastructure.Web;
    #endregion
    public class BaseDomain
    {
        private IBusinessContext _businessContext;

        #region Constructors
        public BaseDomain(IBusinessContext context)
        {
            _businessContext = context;
        }

        public BaseDomain(IWebContext context)
        {
            _businessContext = new BusinessContext(context);
        }
        #endregion

        protected IBusinessContext Context => _businessContext;
    }
}
