using System;
using System.Collections.Generic;

namespace BookCatalog.ViewModel
{
    public class BookVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Rating { get; set; }
        public int PageCount { get; set; }

        #region Navigation property
        public IEnumerable<AuthorVM> Author { get; set; }
        #endregion
    }
}
