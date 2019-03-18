using System.Collections.Generic;

namespace BookCatalog.DAL.Entities
{
    public class EditBookEM : BookEM
    {
        public List<dynamic> AuthorsIds { get; set; }

    }
}
