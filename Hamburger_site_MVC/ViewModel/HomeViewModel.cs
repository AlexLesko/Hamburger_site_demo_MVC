using Hamburger_site_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hamburger_site_MVC.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Burger> BurgetOfTheWeek { get; set; }
    }
}
