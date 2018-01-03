namespace BookCatalog.DAL.Entities
{
    #region Namespaces
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    #endregion


    [Table("tbl_Autors")]
    public class AutorEM
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
