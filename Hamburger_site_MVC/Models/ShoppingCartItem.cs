﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hamburger_site_MVC.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Burger Burger { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}