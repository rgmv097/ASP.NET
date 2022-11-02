using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication5.DAL;
using WebApplication5.Models.Entities;

namespace WebApplication5.ViewComponents
{
    public class DiscountProductsViewComponent:ViewComponent
    {
        public readonly AppDbContext _context;

        public DiscountProductsViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Product> products=await _context.Products
                .Where(x=>x.DiscountPercent!=0)
                .Include(x=>x.Category)
                .ToListAsync();    
            return View(products);
        }
    }
}
