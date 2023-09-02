using SDM.WEB.Service;

namespace SDM.WEB;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();

        builder.Configuration.Bind("Project", new Config());

        var app = builder.Build();

        app.UseRouting();
        app.UseStaticFiles();

        app.MapControllerRoute(
            name: "defatul",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}