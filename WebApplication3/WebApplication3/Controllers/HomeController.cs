using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public List<ShopItems> _items;
        private string[] imgs = { "https://5.imimg.com/data5/GX/JR/GJ/SELLER-74639570/women-and-girls-synthetic-leather-casual-shoes-500x500.jpg", "https://courir.az/image/cache/fotos/adidas-nmd-r1-shoesfv8729-1004-500x500.jpg", "https://courir.az/image/cache/fotos/nike-jordan-air-max-200-sneakerscd6105-108-898-500x500.jpg" };
        public HomeController()
        {

            _items = new List<ShopItems>();
            _items.Add(new ShopItems { Id = 1, Name = "Bershka", Title = "Temiz Kitay malidi qaqa cani", Url = imgs[0], Price = 300 });
            _items.Add(new ShopItems { Id = 2, Name = "Adidas", Title = "Geyin ayaqva qach Husein boltda cata bilmez sene", Url = imgs[1], Price = 670 });
            _items.Add(new ShopItems { Id = 3, Name = "Nike", Title = "Nike di qaqa) ronaldo geyinennen :))", Url = imgs[2], Price = 888 });

        }
        public IActionResult Index()
        {
            return View(_items);
        }
    }
}
