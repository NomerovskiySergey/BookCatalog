using Dapper.Contrib.Extensions;

namespace BookCatalog.DAL.Entities
{
    [Table("tbl_Autor")]
    public class AuthorEM
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
