namespace ST10019838_DamianDare_PROG7311_POE.Models
{
    public class Farmer : User
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;


        //public Admin CreatedBy { get; set; } = null!;
        //public DateTime CreatedAt { get; set; }
        //public DateTime LastUpdated
        //public User LastUpdatedBy

        public int AdminId { get; set; }
        public Admin Admin { get; set; } = null!;
        public ICollection<Product> Products { get; } = new List<Product>();
    }
}
