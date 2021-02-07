using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hamburger_site_MVC.Models;
using Hamburger_site_MVC.ViewModel;

namespace Hamburger_site_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBurgerRepository _burgerRepository;

        public HomeController(IBurgerRepository burgerRepository)
        {
            _burgerRepository = burgerRepository;
        }


        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                BurgetOfTheWeek = _burgerRepository.BurgetOfTheWeek
            };
            return View(homeViewModel);
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
