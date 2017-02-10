using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GummyBearKingdom.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Cost { get; set; }
        [Required]
        public string OriginCountry { get; set; }
    }
}
