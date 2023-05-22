using Microsoft.EntityFrameworkCore;
using OganiMasterMVC.DataAccessLayer;

namespace OganiMasterMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddMvc();

            var connection = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<AppDbContext>(builder =>
            {
                builder.UseSqlServer(connection);
            });

            var app = builder.Build();

            app.UseStaticFiles();
            app.UseRouting();

            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
            });


            app.Run();
        }
    }
}