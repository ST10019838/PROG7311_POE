using Carter;
using ST10019838_DamianDare_PROG7311_POE.Models;

namespace ST10019838_DamianDare_PROG7311_POE.Endpoints;

public class EmployeesEndpoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/employees");

        //group.MapGet("{adminId}", GetEmployee);
        group.MapPost("create", CreateEmployee);
    }

    //public static async Task<User?> GetEmployee(AppDbContext db, int adminId)
    //{
    //    return await db.Users.FindAsync(adminId);
    //    //.OrderBy(m => m.Id)
    //    //.Where(m => m.Id == userId)
    //    //.ToListAsync();
    //}

    public static async Task<int> CreateEmployee(AppDbContext db /*, Module newModule */)
    {
        // 1. First add then save the module
        User newEmployee = new User()
        {
            UserName = "DDare",
            Email = "Boi",
            FirstName = "Damian",
            LastName = "Dare",
            Password = "1234",
            Role = ROLE.EMPLOYEE
        };

        //await db.Users.AddAsync(newEmployee);
        return await db.SaveChangesAsync();
    }
}
