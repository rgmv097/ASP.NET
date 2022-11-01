using WebApplication5.Models;

namespace WebApplication5.ViewModels
{
    public class HomeVM
    {
        public List<SlideIMG> SlideImages { get; set; }=new List<SlideIMG>();
        public List<Category> Categories { get; set; }=new List<Category>();
        public Slider Slider { get; set; }=new Slider();
        public List<Product> Products { get; set; }=new List<Product>();


    }
}
