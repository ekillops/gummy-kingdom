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
        [Required(ErrorMessage = "Please enter product name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter product cost")]
        public decimal Cost { get; set; }
        [Required(ErrorMessage = "Please enter product origin")]
        public string OriginCountry { get; set; }
    }
}
