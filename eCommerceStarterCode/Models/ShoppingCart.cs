using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceStarterCode.Models
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Customer")]
        public string UserId { get; set; }
        public User Customer { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
