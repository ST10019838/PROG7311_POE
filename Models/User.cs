namespace ST10019838_DamianDare_PROG7311_POE.Models
{
    public interface User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        //public Admin CreatedBy { get; set; } = null!;
        //public DateTime CreatedAt { get; set; }
        //public DateTime LastUpdated
        //public User LastUpdatedBy
    }
}
