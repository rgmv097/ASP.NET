using WebApplication5.Models.Entities;

namespace WebApplication5.ViewModels
{
    public class HomeViewModel
    {
        public List<SliderImage> SliderImages { get; set; }=new List<SliderImage>();
        public List<Category> Categories { get; set; }=new List<Category>();
        public Slider Sliders { get; set; }=new Slider();
        public List<Product> Products { get; set; }=new List<Product>();


    }
}
