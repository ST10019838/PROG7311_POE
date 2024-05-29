namespace ST10019838_DamianDare_PROG7311_POE.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Type { get; set; }
        public string? Category { get; set; }
        public string? Description { get; set; }
        public float? Price { get; set; }
        public int? Quantity { get; set; }

        public DateTime? ProductionDate { get; set; }
        public DateTime DateCreated { get; set; }

        public int FarmerId { get; set; }
        public User User { get; set; } = null!;
    }
}
