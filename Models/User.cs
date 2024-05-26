namespace ST10019838_DamianDare_PROG7311_POE.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ROLE Role { get; set; }


        public int? CreatedBy { get; set; }
        public ICollection<Product>? Products { get; } = new List<Product>();

        //public Admin CreatedBy { get; set; } = null!;
        //public DateTime CreatedAt { get; set; }
        //public DateTime LastUpdated
        //public User LastUpdatedBy
    }

    public enum ROLE
    {
        EMPLOYEE,
        FARMER
    }
}
