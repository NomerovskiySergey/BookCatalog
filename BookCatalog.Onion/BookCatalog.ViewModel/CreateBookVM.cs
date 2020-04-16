using System.Collections.Generic;

namespace BookCatalog.ViewModel
{
    public class CreateBookVM : BookVM
    {
        public IEnumerable<int> AuthorsIds { get; set; }
    }
}
