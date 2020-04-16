using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookCatalog.ViewModel
{
    public class BookVM
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ReleaseDate { get; set; }
        [Required]
        [Range(0, 10, ErrorMessage = "Please enter valid rating")]
        public int Rating { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid count of page")]
        public int PageCount { get; set; }
        public string Author { get; set; }
        [Required]
        public IEnumerable<int> AuthorsIds { get; set; }
    }
}
