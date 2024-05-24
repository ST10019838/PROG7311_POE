using System.ComponentModel.DataAnnotations;

namespace ST10019838_DamianDare_PROG7311_POE.Models
{
    public class FarmerFormModel
    {
        [Required(ErrorMessage = "First Name is required")]
        [DataType(DataType.Text)]
        [MaxLength(255, ErrorMessage = "Can't exceed 255 characters")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Last Name is required")]
        [DataType(DataType.Text)]
        [MaxLength(255, ErrorMessage = "Can't exceed 255 characters")]
        public string LastName { get; set; } = null!;


        [Required(ErrorMessage = "Email is required")]
        [MaxLength(255, ErrorMessage = "Can't exceed 255 characters")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; } = null!;


        [Required(ErrorMessage = "Password is required")]
        [MaxLength(255, ErrorMessage = "Can't exceed 255 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Password Confirmation is required")]
        [Compare(nameof(Password), ErrorMessage = "Passwords don't match")]
        [MaxLength(255, ErrorMessage = "Can't exceed 255 characters")]
        [DataType(DataType.Password)]
        public string PasswordConfirmation { get; set; } = null!;
    }
}
