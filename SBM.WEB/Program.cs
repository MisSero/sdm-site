namespace SBM.WEB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();


            var app = builder.Build();

            app.UseRouting();

            app.UseStaticFiles();

            app.MapControllerRoute(
                name: "defatul",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}