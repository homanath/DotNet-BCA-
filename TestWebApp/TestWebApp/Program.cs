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
            //www.abc.com/home/index
            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}
