﻿namespace BookCatalog.DAL.Entities
{
    #region Namespaces
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    #endregion

    [Table("tbl_Books")]
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
