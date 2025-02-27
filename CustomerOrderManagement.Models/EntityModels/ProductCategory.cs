﻿using System.Collections.Generic;

namespace CustomerOrderManagement.Models.EntityModels
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();  
    }
}
