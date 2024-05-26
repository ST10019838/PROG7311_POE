using Carter;
using ST10019838_DamianDare_PROG7311_POE.Models;

namespace ST10019838_DamianDare_PROG7311_POE.Endpoints;

public class AdminsEndpoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/admins");

        group.MapGet("{adminId}", GetAdmin);
        group.MapPost("create", CreateAdmin);
    }

    public static async Task<Admin?> GetAdmin(AppDbContext db, int adminId)
    {
        return await db.Admins.FindAsync(adminId);
        //.OrderBy(m => m.Id)
        //.Where(m => m.Id == userId)
        //.ToListAsync();
    }

    public static async Task<int> CreateAdmin(AppDbContext db /*, Module newModule */)
    {
        // 1. First add then save the module
        Admin newAdmin = new Admin() { Email = "Boi", FirstName = "Damian", LastName = "Dare", Password = "1234" };

        await db.Admins.AddAsync(newAdmin);
        return await db.SaveChangesAsync();
    }
}
