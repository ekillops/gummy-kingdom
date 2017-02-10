using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GummyBearKingdom.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [HiddenInput]
        public int ProductId { get; set; }
        [Url]
        public string ImageUrl { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Cost { get; set; }
        [Required]
        public string OriginCountry { get; set; }
    }
}
