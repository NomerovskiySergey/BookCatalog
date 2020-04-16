namespace BookCatalog.DAL.Entities
{
    using System;
    using Dapper.Contrib.Extensions;

    [Table("tbl_Book")]
    public class BookEM
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Rating { get; set; }
        public int PageCount { get; set; }
    }
}
