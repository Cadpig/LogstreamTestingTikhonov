using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TikhonovWebsite.DBContext
{
    public partial class Category
    {

        public Category(string p1, string p2, int p3)
        {
            Name = p1;
            Path = p2;
            Id = p3;
        }

        public string Name { get; set; }
        public string Path { get; set; }
        public int Id { get; set; }
    }
}
