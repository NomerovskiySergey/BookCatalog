namespace BookCatalog.Business
{
    #region Namespaces
    using Infrastructure.Business;
    using Infrastructure.Web;
    #endregion
    public class BookDM : BusinessContext, IBookDM
    {
        #region Constructors
        public BookDM(IWebContext context) : base(context) { }
        #endregion
    }
}
