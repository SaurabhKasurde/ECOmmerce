using ConcreteClass.AdminLoginConcrete;
using IinterfaceClasses.Login_Interface;

namespace ECOmmerce
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //Add services for interface and its implementation
            builder.Services.AddScoped<IadminLogin, AdminLoginConcrete>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseRouting();

            app.UseAuthorization();

            //app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            //    .WithStaticAssets();

            app.Run();
        }
    }
}
