﻿namespace WebApplication5.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        List<Product>? Products { get; set; }


    }
}
