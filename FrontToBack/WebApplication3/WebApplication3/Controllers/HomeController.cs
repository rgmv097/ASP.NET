using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication3.DAL;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;
       
        public HomeController(AppDbContext context)
        { 
            _context = context;

        }
        public IActionResult Index()
        {
            List<ShopItems> shops = _context.shopItems.ToList();
            return View(shops);
        }
    }
}
