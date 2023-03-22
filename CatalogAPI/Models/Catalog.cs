using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CatalogAPI.Models
{
     //user 3 modifying the code
     //add sub catelog name

    [Table("Catalog")]
    public class Catalog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required] //user2
        [Column("Catalog_Id")]
        public long CatalogId { get; set; }
        [Column("Catalog_Name")]
        [Required]
        [StringLength(50)]
         //user 3 update
        public string? CatalogName { get; set; }

        //[JsonIgnore]       
       // public Collection<Product> ProductList { get; set; }


    }
}
