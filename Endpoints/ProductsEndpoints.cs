using Carter;
using ST10019838_DamianDare_PROG7311_POE.Models;

namespace ST10019838_DamianDare_PROG7311_POE.Endpoints;

public class ProductsEndpoints : ICarterModule
{

    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/products");

        group.MapGet("{productId}", GetProduct);
        group.MapPost("create", CreateProduct);
    }

    public static async Task<Product?> GetProduct(AppDbContext db, int productId)
    {
        return await db.Products.FindAsync(productId);
        //.OrderBy(m => m.Id)
        //.Where(m => m.Id == userId)
        //.ToListAsync();
    }

    public static async Task<int> CreateProduct(AppDbContext db /*, Module newModule */)
    {
        // 1. First add then save the module
        Product newProduct = new Product() { Description = "nah" };

        await db.Products.AddAsync(newProduct);
        return await db.SaveChangesAsync();
    }
}

