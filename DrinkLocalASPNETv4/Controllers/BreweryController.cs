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

        public IActionResult Index(string city)
        {
            var brewery = BreweryRepo.GetBreweriesRESTSharp(city);

            return View(brewery);
        }
       

        public IActionResult ViewBrewery(string id)
        {
            var location = BreweryRepo.GetBreweryById(id);

            location = BreweryRepo.GetBreweryMap(location);

            return View(location);
        }

    }
}
