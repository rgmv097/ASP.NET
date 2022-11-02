namespace WebApplication5.Models.Entities
{
    public class Category:Entity
    {
        
        public string? Name { get; set; }
        List<Product>? Products { get; set; }


    }
}
