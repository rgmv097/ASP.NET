namespace WebApplication5.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public string? ImageUrl { get; set; }
        public virtual Category? Category { get; set; }
        public int ? CategoryId { get; set; }

    }
}
