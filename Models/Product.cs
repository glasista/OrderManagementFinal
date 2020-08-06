﻿using System.Collections.Generic;

namespace OrderManagement.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
