namespace ST10019838_DamianDare_PROG7311_POE.Models
{
    public class Farmer
    {
        public Auth0_User Information { get; set; } = null!;
        public List<Product> Products { get; set; } = null!;


        // The following function was adapted from GeeksForGeeks.com
        // Author: Sabya_S
        // Link: https://www.geeksforgeeks.org/shallow-copy-and-deep-copy-in-c-sharp/
        public Farmer DeepCopyWithEmptyProducts()
        {
            Farmer copy = new Farmer()
            {
                Information = this.Information,
                Products = this.Products,
            };

            copy.Products.Clear();

            return copy;
        }
    }
}
