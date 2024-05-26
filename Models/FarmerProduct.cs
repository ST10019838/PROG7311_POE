namespace ST10019838_DamianDare_PROG7311_POE.Models
{
    public class FarmerProduct
    {
        public int Id { get; set; }

        public User Farmer { get; set; } = null!;
        public Product Product { get; set; } = null!;
    }
}
