using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hamburger_site_MVC.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int BurgerId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Burger Burger { get; set; }
        public Order Order { get; set; }
    }
}
