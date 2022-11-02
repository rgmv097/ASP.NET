namespace WebApplication5.Models.Entities
{
    public class Product: Entity
    {
        
        public string? Name { get; set; }
        public int Price { get; set; }
        public string? ImageUrl { get; set; }
        public virtual Category? Category { get; set; }
        public int? CategoryId { get; set; }
        public double DiscountPercent { get; set; }

    }
}
