using System.ComponentModel.DataAnnotations;

namespace BookCatalog.ViewModel
{
    public class AuthorVM
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}
