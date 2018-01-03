namespace BookCatalog.ViewModel
{
    #region Namespaces
    using System;
    #endregion

    public class BookVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Rating { get; set; }
        public int PageCount { get; set; }
    }
}
