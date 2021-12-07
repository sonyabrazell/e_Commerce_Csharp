using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceStarterCode.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public string ReviewContent { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("Customer")]
        public string UserId { get; set; }
        public User Customer { get; set; }
    }
}
