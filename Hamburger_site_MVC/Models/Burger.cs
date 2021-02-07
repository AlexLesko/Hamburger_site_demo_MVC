using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hamburger_site_MVC.Models
{
    public class Burger
    {
        public int BurgerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageAlt { get; set; }
        public bool IsBurgetOfTheWeek { get; set; }
    }
}
