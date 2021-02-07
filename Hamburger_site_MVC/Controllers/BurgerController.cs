using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hamburger_site_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hamburger_site_MVC.Controllers
{
    public class BurgerController : Controller
    {
        private readonly IBurgerRepository _burgerRepository;

        public BurgerController(IBurgerRepository burgerRepository)
        {
            _burgerRepository = burgerRepository;
        }

        public IActionResult BurgerList()
        {
            return View(_burgerRepository.AllBurger);
        }

        public IActionResult BurgerDetail(int id)
        {
            var burger = _burgerRepository.GetBurgerById(id);

            if (burger == null)
                return NotFound();

            return View(burger);
        }
    }
}
