﻿using Microsoft.EntityFrameworkCore;
using WebApplication5.Models;

namespace WebApplication5.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<SlideIMG> SlideIMG { get; set; }
    }
}
