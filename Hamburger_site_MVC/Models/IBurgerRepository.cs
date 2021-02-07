using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hamburger_site_MVC.Models
{
    public interface IBurgerRepository
    {
        IEnumerable<Burger> AllBurger { get; }
        IEnumerable<Burger> BurgetOfTheWeek { get; }
        Burger GetBurgerById (int burgerId);
    }
}
