using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.DAL
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions option) : base(option)
        {

        }
        public DbSet<Slider>? Sliders { get; set; }
        public DbSet<Category>? Categories { get; set; }

    }
}
