using Carter;
using Microsoft.EntityFrameworkCore;
using ST10019838_DamianDare_PROG7311_POE.Models;

namespace ST10019838_DamianDare_PROG7311_POE.Endpoints;

public class FarmersEndpoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/farmers");

        group.MapGet("", GetAllFarmers);
        group.MapGet("{farmerId}", GetFarmer);
        group.MapPost("create", CreateFarmer);


        //group.MapGet("is-empty/{userId}", HasEmptyModuleStorageFor);

        //group.MapPost("days-set-aside/save", SaveDaysSetAside);

        //group.MapGet("module-code/uniqueness/{moduleCode}/{userId}", IsModuleCodeUnique);
    }

    public static async Task<List<User>> GetAllFarmers(AppDbContext db)
    {
        return await db.Users.Where(u => u.Role == ROLE.FARMER).ToListAsync();
        //.OrderBy(m => m.Id)
        //.Where(m => m.Id == userId)
        //.ToListAsync();

    }

    public static async Task<User?> GetFarmer(AppDbContext db, int farmerId)
    {
        return await db.Users.FindAsync(farmerId);
        //.OrderBy(m => m.Id)
        //.Where(m => m.Id == userId)
        //.ToListAsync();

    }

    public static async Task<int> CreateFarmer(AppDbContext db, FarmerFormModel form)
    {
        // 1. First add then save the module
        User newFarmer = new User()
        {
            UserName = "DDare",
            Email = form.Email,
            FirstName = form.FirstName,
            LastName = form.LastName,
            Password = form.Password,
            CreatedBy = 2,
            Role = ROLE.FARMER
        };



        await db.Users.AddAsync(newFarmer);
        return await db.SaveChangesAsync();
    }



    //public static async Task<int> AddModule(AppDbContext db /*, Module newModule */)
    //{
    //    // 1. First add then save the module


    //    await db.Farmers.AddAsync(newModule);
    //    await db.SaveChangesAsync();

    //    // 2. Then calculate the modules self study hours for that module
    //    newModule.SelfStudyHoursPerWeek = CalculateSelfStudyHoursFor(newModule);
    //    return await _context.SaveChangesAsync();
    //}

    //public static bool IsModuleCodeUnique(List<Module> data, string moduleCode)
    //{
    //    // DavidG reminded me that Entity framework comes with async methods...
    //    // Author: DavidG
    //    // Link: https://stackoverflow.com/questions/46297613/returning-taskbool-from-linqs-any-method
    //    return !data.Any(module => module.Code.Equals(moduleCode));
    //}

    //public static async Task<bool> HasEmptyModuleStorageFor(int userId)
    //{
    //    return await _context.Modules
    //        .Where(m => m.UserID == userId)
    //        .CountAsync() == 0 ? true : false;
    //}

    //public static async Task<int> SaveDaysSetAside(Dictionary<int, string?> modules)
    //{
    //    foreach (var module in modules)
    //    {
    //        var moduleToUpate = await _context.Modules.FindAsync(module.Key);
    //        moduleToUpate.DaySetAside = module.Value;
    //    }

    //    return await _context.SaveChangesAsync();
    //}

    //public static int CalculateSelfStudyHoursFor(Module module)
    //{
    //    // The calculation for the self study hours was provided in the POE document.
    //    // To do the calulation, I converted the fraction in the equation to a double
    //    // so that it can be rounded up in case of a decimal result. This is done to 
    //    // to ensure that the slightly extra time is accounted for. Also in my opinion,
    //    // I believe it is better to over-study than to under-study.
    //    int selfStudyHours = (int)Math.Ceiling(Convert.ToDouble(module.Credits * 10) / Convert.ToDouble(module.Semester.NumberOfWeeks)) - module.ClassHoursPerWeek;

    //    // If the hours turn out to be less than or equal to 0 (due to incorrect information entered),
    //    // the hours studied will be 0, as you can't study negative hours.
    //    return selfStudyHours <= 0 ? 0 : selfStudyHours;
    //}

}

