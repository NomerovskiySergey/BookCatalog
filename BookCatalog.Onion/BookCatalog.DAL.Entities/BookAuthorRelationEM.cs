namespace BookCatalog.DAL.Entities
{
    using Dapper.Contrib.Extensions;

    [Table("tbl_Authors_Books_Relation")]
    public class BookAuthorRelationEM
    {
        [Key]
        public int Id { get; set; }
        public  int AuthorId { get; set; }
        public int BookId { get; set; }
    }
}
