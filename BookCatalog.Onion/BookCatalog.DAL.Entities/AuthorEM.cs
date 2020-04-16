namespace BookCatalog.DAL.Entities
{
    using Dapper.Contrib.Extensions;

    [Table("tbl_Author")]
    public class AuthorEM
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
