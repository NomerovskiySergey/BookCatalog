using Dapper.Contrib.Extensions;

namespace BookCatalog.DAL.Entities
{
    [Table("tbl_Book")]
    public class BookAuthorRelationEM
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public int AuthorId { get; set; }
    }
}
