using DrinkLocalASPNETv4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection.Emit;


namespace DrinkLocalASPNETv4.Controllers
{
    public class BreweryController : Controller
    {
        private readonly BreweryRepo repo;

        public BreweryController(BreweryRepo breweryRepo)
        {
            this.repo = breweryRepo;
        }

        public IActionResult Index(string city)
        {
            var brewery = new Brewery();

            if(city == null)
            {
                return View(brewery);
            }
            try
            {
                var brewList = BreweryRepo.GetBreweriesRESTSharp(city);

            }
            catch(AggregateException)
            {
                return RedirectToAction("Index", "Brewery");
            }
            return View(brewery);
        }
        public IActionResult Brewery(string city)
        {
            var brewery = new Brewery();

            if(city == null)
            {
                return View(brewery);
            }

            var brewList = BreweryRepo.GetBreweriesRESTSharp(city);
            return View(brewList);
        }
    }
}
