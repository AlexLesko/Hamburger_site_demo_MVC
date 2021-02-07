using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Hamburger_site_MVC.Models
{
    public class BurgerRepository: IBurgerRepository
    {
        private readonly AppDbContext _appDbContext;

        public BurgerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Burger> AllBurger
        {
            get
            {
                return _appDbContext.Burgers;
            }
        }
        public IEnumerable<Burger> BurgetOfTheWeek
        {
            get
            {
                return _appDbContext.Burgers.Where(p => p.IsBurgetOfTheWeek);
            }
        }
        public Burger GetBurgerById(int burgerId)
        {
            return _appDbContext.Burgers.FirstOrDefault(p => p.BurgerId == burgerId);
        }

    }
}
