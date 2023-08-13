using System.ComponentModel.DataAnnotations;

namespace ecommerce_web.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public required string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
