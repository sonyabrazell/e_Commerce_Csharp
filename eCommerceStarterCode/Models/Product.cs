using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceStarterCode.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public int Rating { get; set; }

        [ForeignKey("Seller")]
        public string UserId { get; set; }
        public User Seller { get; set; }
    }
}
