using DrinkLocalASPNETv4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DrinkLocalASPNETv4.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index(string city)
        {
            var brewery = new Brewery();
            if(city == null)
            {
                return View(brewery);
            }
            brewery = BreweryRepo.GetBreweries(city);

            return View(brewery);
        }

        
    }
}