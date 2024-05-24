using System.ComponentModel.DataAnnotations;

namespace ST10019838_DamianDare_PROG7311_POE.Models
{
    public class ProductFormModel
    {
        [Required(ErrorMessage = "First Name is required")]
        [DataType(DataType.Text)]
        [MaxLength(255, ErrorMessage = "Can't exceed 255 characters")]
        public string Name { get; set; } = null!;


        [DataType(DataType.MultilineText)]
        [MaxLength(255, ErrorMessage = "Can't exceed 255 characters")]
        public string? Description { get; set; }

        public Category? Category { get; set; }


        [Range(0, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public float? Price { get; set; }


        [Range(0, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public int? Quantity { get; set; }
    }
}
