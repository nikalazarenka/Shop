﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }
        public Clothes Clothes { get; set; }
        public decimal Price { get; set; }
        public string ShopCartId { get; set; }
    }
}
