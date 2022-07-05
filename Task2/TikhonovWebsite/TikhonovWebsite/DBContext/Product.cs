using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TikhonovWebsite.DBContext
{
    public partial class Product
    {
        public Product(int p1, string p2, string p3, string p4, string p5, string p6, int p7)
        {
            Id = p1;
            Path = p2;
            Title = p3;
            Price = p4;
            Specifications = p5;
            Description = p6;
            CategoryId = p7;
        }

        public int Id { get; set; }
        public string Path { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
        public string Specifications { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
    }
}
