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
        private BreweryRepo repo;

        public BreweryController(BreweryRepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index(string city)
        {
            var brewery = BreweryRepo.GetBreweriesRESTSharp(city);

            return View(brewery);
        }
        
    }
}
