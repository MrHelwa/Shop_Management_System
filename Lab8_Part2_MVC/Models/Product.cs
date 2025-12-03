using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab8_Part2_MVC.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Display(Name = "Product Image")]
        public string? Image { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 1000000, ErrorMessage = "Price must be between 0.01 and 1,000,000")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Customer is required")]
        [ForeignKey("Customer")]
        [Display(Name = "Customer")]
        public int CustID { get; set; }

        // Navigation property
        public virtual Customer? Customer { get; set; }
    }
}