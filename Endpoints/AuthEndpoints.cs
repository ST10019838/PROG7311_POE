
using Carter;
using Microsoft.EntityFrameworkCore;
using ST10019838_DamianDare_PROG7311_POE.Models;

namespace ST10019838_DamianDare_PROG7311_POE.Endpoints;

public class AuthEndpoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/auth");

        group.MapPost("login", Login);
        group.MapPost("is-username-unique", IsUsernameUnique);
        //group.MapGet("logout", Logout);
    }

    //public static async Task<IResult> Login(HttpContext context, IAuthorizationConfigurationProvider _authConfigurationProvider, IApplicationConfigurationProvider _appConfigurationProvider)
    //{
    //    // We need some artificial id to correlate user session to client instance

    //    // NOTE: Session.Id will be always random, we need to add something to session to make it persistent.
    //    var correlationId = context.Session?.GetString("KindeCorrelationId");

    //    if (string.IsNullOrEmpty(correlationId))
    //    {
    //        correlationId = Guid.NewGuid().ToString();
    //        context.Session?.SetString("KindeCorrelationId", correlationId);
    //    }

    //    // Get client's instance...
    //    var client = KindeClientFactory.Instance.GetOrCreate(correlationId, _appConfigurationProvider.Get());

    //    // ...and authorize it
    //    await client.Authorize(_authConfigurationProvider.Get());

    //    // if auth flow is not ClientCredentials flow, we need to redirect user to another page
    //    //if (client.AuthorizationState == Kinde.Api.Enums.AuthorizationStates.UserActionsNeeded)
    //    //{
    //    //    // redirect user to login page
    //    //    return Redirect(await client.GetRedirectionUrl(correlationId));
    //    //}
    //    //return RedirectToAction("Index");
    //    return Results.Ok();
    //}


    public static async Task<User> Login(AppDbContext db, UserCredentials credentials)
    {
        //await Task.Delay(1000);
        //return "Hi";
        return await db.Users.SingleAsync(u => u.UserName.Equals(credentials.UserName) && u.Password.Equals(credentials.Password));
    }

    //public static async Task Logout(AppDbContext db, string redirectUri = "/")
    //{

    //}

    public static async Task<bool> IsUsernameUnique(AppDbContext db, string username)
    {
        return !await db.Users.AnyAsync(u => u.UserName.Equals(username));
    }
}


