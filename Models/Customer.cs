﻿using System.Collections.Generic;

namespace OrderManagement.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
