namespace BookCatalog.Business.Author
{
    #region
    using Infrastructure.Business;
    using Infrastructure.Web;
    #endregion

    public class AuthorDM : BaseDomain
    {
        #region Constructors
        public AuthorDM(IWebContext context) : base(context) { }

        public AuthorDM(IBusinessContext context) : base(context) { }
        #endregion
    }
}
