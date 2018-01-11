﻿using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace BookCatalog.DAL.Entities
{
    [Table("tbl_Book")]
    public class BookEM
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Rating { get; set; }
        public int PageCount { get; set; }

        #region Navigation property
        public IEnumerable<AuthorEM> Author { get; set; }
        #endregion
    }
}
