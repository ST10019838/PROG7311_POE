using Carter;
using Microsoft.EntityFrameworkCore;
using ST10019838_DamianDare_PROG7311_POE.Models;
using System.ComponentModel.DataAnnotations;

namespace ST10019838_DamianDare_PROG7311_POE.Endpoints;

public class ProductsEndpoints : ICarterModule
{

    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/products");

        group.MapGet("", GetAllProducts);
        group.MapGet("{productId}", GetProduct);
        group.MapPost("create", CreateProduct);
    }

    public static async Task<List<Product>> GetAllProducts(AppDbContext db)
    {
        return await db.Products.ToListAsync();
        //.OrderBy(m => m.Id)
        //.Where(m => m.Id == userId)
        //.ToListAsync();
    }

    public static async Task<Product?> GetProduct(AppDbContext db, int productId)
    {
        return await db.Products.FindAsync(productId);
        //.OrderBy(m => m.Id)
        //.Where(m => m.Id == userId)
        //.ToListAsync();
    }

    public static async Task<IResult> CreateProduct(AppDbContext db, ProductFormModel form /* farmerId */)
    {
        // 1. First add then save the module
        bool isValid = Validator.TryValidateObject(form,
                new ValidationContext(form, serviceProvider: null, items: null),
                new List<ValidationResult>(),
                true);

        // fix this
        if (!isValid)
        {
            return Results.BadRequest();
        }

        Product newProduct = new Product()
        {
            Name = form.Name,
            Category = form.Category,
            Description = form.Description,
            Price = form.Price,
            Quantity = form.Quantity,
        };

        await db.Products.AddAsync(newProduct);
        await db.SaveChangesAsync();
        return Results.Created();
    }
}

