
using Auth0.AspNetCore.Authentication;
using Carter;
using Kinde.Api.Models.Configuration;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using ST10019838_DamianDare_PROG7311_POE.Models;
using ST10019838_DamianDare_PROG7311_POE.Ui;

var builder = WebApplication.CreateBuilder(args);


builder.Services
    .AddAuth0WebAppAuthentication(options =>
    {
        options.Domain = "dev-bxovn1jfn7dlv57b.eu.auth0.com";
        options.ClientId = "yicG2kYHHM6BTwwnNRQWVSunSBvm0LNe";
    });


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();




// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
         policy =>
         {
             policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
         });
});


builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri(builder.Configuration["FrontendUrl"] ?? "https://localhost:3333")
    });

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection")));


builder.Services.AddHttpClient();
builder.Services.AddMudServices();
builder.Services.AddCarter();



builder.Services.AddTransient<IAuthorizationConfigurationProvider, DefaultAuthorizationConfigurationProvider>();
builder.Services.AddTransient<IApplicationConfigurationProvider, DefaultApplicationConfigurationProvider>();
builder.Services.AddSession();


builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(3600);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});



var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseSession();

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.UseCors();
app.MapCarter();



//app.MapGet("/Account/Login", async (HttpContext httpContext, string redirectUri = "/") =>
//{
//    var authenticationProperties = new LoginAuthenticationPropertiesBuilder()
//    .WithRedirectUri(redirectUri)
//    .Build();

//    await httpContext.ChallengeAsync(Auth0Constants.AuthenticationScheme, authenticationProperties);
//});

//app.MapGet("/Account/Logout", async (HttpContext httpContext, string redirectUri = "/") =>
//{
//    var authenticationProperties = new LogoutAuthenticationPropertiesBuilder()
//.WithRedirectUri(redirectUri)
//.Build();

//    await httpContext.SignOutAsync(Auth0Constants.AuthenticationScheme, authenticationProperties);
//    await httpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
//});


app.Use((context, next) => { context.Request.Scheme = "https"; return next(); });
//app.Run();

app.Run("https://localhost:3333");
