using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication3.DAL;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
       

        }


        

        public IActionResult Detail(int? id)
        {
            if (id is null) return BadRequest();
            List<ShopItems> shops = _context.shopItems.ToList();
            ShopItems shopItem = shops.Find(n => n.Id == id);
            if (shopItem is null) return NotFound();
            return View(shopItem);
            
        }
    }
}
