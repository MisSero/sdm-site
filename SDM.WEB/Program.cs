using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using SDM.DAL.EF;
using SDM.DAL.Interfaces;
using SDM.DAL.Repositories;
using SDM.WEB.Service;

namespace SDM.WEB;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();

        builder.Configuration.Bind("Project", new Config());

        builder.Services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(Config.ConnectionString);
        });

        builder.Services.AddTransient<ITextFieldsRepository, EFTextFieldsRepository>();
        builder.Services.AddTransient<IServiceItemsRepository, EFServiceItemsRepository>();

        builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
        {
            options.User.RequireUniqueEmail = true;
            options.Password.RequiredLength = 6;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;
            options.Password.RequireDigit = false;
        }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

        builder.Services.ConfigureApplicationCookie(options =>
        {
            options.Cookie.Name = "SDMAuth";
            options.Cookie.HttpOnly = true;
            options.LoginPath = "/account/login";
            options.AccessDeniedPath = "/account/accessdenied";
            options.SlidingExpiration = true;
        });

        var app = builder.Build();

        app.UseRouting();

        app.UseStaticFiles();

        app.UseCookiePolicy();
        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllerRoute(
            name: "defatul",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}