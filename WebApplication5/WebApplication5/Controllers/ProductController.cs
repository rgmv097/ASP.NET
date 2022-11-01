using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication5.DAL;

namespace WebApplication5.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ProductController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var products=_dbContext.Products.Include(p => p.Category).ToList();
            return View(products);
        }
        public IActionResult Details(int id)
        {
            var product = _dbContext.Products.Include(p=> p.Category).SingleOrDefault(p => p.Id == id);
            return View(product);
        }
    }
}
