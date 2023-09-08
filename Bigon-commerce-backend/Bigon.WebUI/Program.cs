using Bigon.WebUI.Models.Persistences;
using Microsoft.EntityFrameworkCore;

namespace Bigon.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<DataContext>(cfg =>
            {
                cfg.UseSqlServer(builder.Configuration.GetConnectionString("cString"));
            });

            var app = builder.Build();

            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(cfg => {
            cfg.MapControllerRoute("default","{controller=home}/{axtion=index}/{id?}");
            });
           

            app.Run();
        }
    }
}