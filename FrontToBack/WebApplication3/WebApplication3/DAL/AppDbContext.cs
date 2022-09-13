using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<ShopItems> shopItems { get; set; }
    }
}
