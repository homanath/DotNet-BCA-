namespace TestWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder= WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseStaticFiles();
            //localhost:port/home/index
            // app.MapDefaultControllerRoute();
            app.MapControllerRoute(name = "myRoute", pattern: "{controller=Home}/{action=index}/{id}");

            app.Run();
        }
    }
}
