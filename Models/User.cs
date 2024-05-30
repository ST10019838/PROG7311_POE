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


        // The following function was adapted from GeeksForGeeks.com
        // Author: Sabya_S
        // Link: https://www.geeksforgeeks.org/shallow-copy-and-deep-copy-in-c-sharp/
        public User DeepCopyWithEmptyProducts()
        {
            User copy = new User()
            {
                Id = this.Id,
                UserName = this.UserName,
                Email = this.Email,
                Password = this.Password,
                FirstName = this.FirstName,
                LastName = this.LastName,
                Role = this.Role,
                CreatedBy = this.CreatedBy,
            };

            copy.Products.Clear();

            return copy;
        }
    }

    public enum ROLE
    {
        EMPLOYEE,
        FARMER
    }
}
