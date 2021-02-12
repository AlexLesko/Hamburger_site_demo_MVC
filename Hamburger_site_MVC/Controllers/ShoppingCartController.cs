using Hamburger_site_MVC.Models;
using Hamburger_site_MVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hamburger_site_MVC.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IBurgerRepository _burgerRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IBurgerRepository burgerRepository, ShoppingCart shoppingCart)
        {
            _burgerRepository = burgerRepository;
            _shoppingCart = shoppingCart;
        }
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int burgerId)
        {
            var selectedBurger = _burgerRepository.AllBurger.FirstOrDefault(p => p.BurgerId == burgerId);

            if (selectedBurger != null)
            {
                _shoppingCart.AddToCart(selectedBurger, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int burgerId)
        {
            var selectedBurger = _burgerRepository.AllBurger.FirstOrDefault(p => p.BurgerId == burgerId);

            if (selectedBurger != null)
            {
                _shoppingCart.RemoveFromCart(selectedBurger);
            }
            return RedirectToAction("Index");
        }
    }
}
