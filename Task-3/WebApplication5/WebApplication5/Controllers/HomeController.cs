﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication5.DAL;
using WebApplication5.Models;
using WebApplication5.ViewModels;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var sliderImages=_dbContext.SliderImages.ToList();
            var sliders = _dbContext.Sliders.SingleOrDefault();
            var categories=_dbContext.Categories.ToList();
            var products=_dbContext.Products.ToList();
            var homeViewModel = new HomeViewModel
            {
                SliderImages = sliderImages,
                Sliders = sliders,
                Categories = categories,
                Products = products,
            };
            return View(homeViewModel);
        }
    }
}
