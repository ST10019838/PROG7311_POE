namespace ST10019838_DamianDare_PROG7311_POE.Models
{
    public class Admin : User
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        // Allow admins to create the categories for the products

        public ICollection<Farmer> Farmers { get; } = new List<Farmer>();
    }
}
