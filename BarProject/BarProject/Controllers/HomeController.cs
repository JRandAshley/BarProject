using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BarProject.Models;
using BarProject.ViewModels;

namespace BarProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;
        private readonly IMockMenu _menuRepository;

        public HomeController(IDrinkRepository drinkRepository, IMockMenu mockMenu)
        {
            _drinkRepository = drinkRepository;
            _menuRepository = mockMenu;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //public ViewResult Details(String Name)
        //{

            //Drink drink = _drinkRepository.GetDrink(Name.Value);
            //if (volunteer == null)
            //{
            //    Response.StatusCode = 404;
            //    return View("VolunteerNotFound", ID.Value);
            //}

            //HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            //{
            //    Volunteer = volunteer,
            //    PageTitle = "Volunteer Details"
            //};
            //return View(homeDetailsViewModel);
        //}

        [HttpGet]
        public ViewResult orderPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult orderPage(orderPageViewModel model)
        {
            if (ModelState.IsValid)
            {
                Drink newDrink = new Drink
                {
                    Name = model.Name,
                    Mixes = model.Mixes,
                    Liquors = model.Liquors,
                    Shakers = model.Shakers,
                    Glasses = model.Glasses,
                    Garnishes = model.Garnishes
                    
                };

                _drinkRepository.Add(newDrink);
                //return RedirectToAction("details", new { Name = newDrink.Name });
                return RedirectToAction("Index");
            }
            return View();
        }

        public ViewResult menuPage()
        {
            var model = _menuRepository.GetAllDrinks();
            ViewData["MenuItems"] = model;
            return View();
        }

        public IActionResult serve()
        {
            _drinkRepository.Delete();
            //return RedirectToAction("details", new { Name = newDrink.Name });
            return RedirectToAction("drinkQueue");
        }

        public IActionResult order(String name, String mixes, 
            String liquors, String shakers, String glasses, String garnishes)
        {
            Drink newDrink = new Drink
            {
                Name = name,
                Mixes = mixes,
                Liquors = liquors,
                Shakers = shakers,
                Glasses = glasses,
                Garnishes = garnishes

            };
            //Drink drinkToAdd = drink;
            _drinkRepository.Add(newDrink);
            return RedirectToAction("Index");
        }

        public IActionResult drinkQueue()
        {
            //Drink drink = new Drink() { Name = "the drink", Shakers = "shaker", Liquors = "rum", Mixes = "mix", Glasses = "glass", Garnishes = "leaf" };

            Array model = _drinkRepository.GetAllDrinks();
            ViewData["AllDrinks"] = model;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
