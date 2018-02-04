using System.Collections.Generic;

namespace BookCatalog.DAL.Entities
{
    public class EditBookEM : BookEM
    {
        public List<int> AuthorsIds { get; set; }
    }
}
