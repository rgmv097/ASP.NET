using Microsoft.EntityFrameworkCore;
using WebApplication5.DAL;

namespace WebApplication5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddMvc();
            builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();
            app.UseStaticFiles();

            app.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");

            app.Run();
        }
    }
}