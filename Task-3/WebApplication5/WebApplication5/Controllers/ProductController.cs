using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication5.DAL;

namespace WebApplication5.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _dbContext;
        private int _productCount;

        public ProductController(AppDbContext dbContext)
        {

            _dbContext = dbContext;
            _productCount =_dbContext.Products.Count();


        }

        public IActionResult Index()
        {
            ViewBag.productCount = _productCount;
            var products=_dbContext.Products.Include(p => p.Category).Take(4).ToList();
            return View(products);
        }
        public IActionResult Details(int? id)
        {
            if(id==null)
            return NotFound();
            var product = _dbContext.Products.Include(p=> p.Category).SingleOrDefault(p => p.Id == id);
            if (product == null)
            return NotFound();
            return View(product);
        }

        public IActionResult Partial(int skip)
        {
            var products = _dbContext.Products.Include(p => p.Category).Skip(skip).Take(4).ToList();
            return PartialView("_ProductPartial",products);
        }
    }
}
