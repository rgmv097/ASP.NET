using Microsoft.AspNetCore.Mvc;
using WebApplication3.DAL;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
    
        public IActionResult Index()
        {
            List<Category> categories = _context.Categories.ToList();
            List<Slider> sliders = _context.Sliders.ToList();

            var homevm = new HomeVM
            {
                Categories = categories,
                Sliders = sliders,
            };
            return View(homevm);


        }
    }
}
