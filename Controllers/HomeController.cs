using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SWAPI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SWAPI.Controllers
{
    public class HomeController : Controller
    {
        private StarWarsDAL swd = new StarWarsDAL();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int personId, int planetId)
        {
            Person per = swd.ConvertToPerson(personId);
            Planet pla = swd.ConvertToPlanet(planetId);
            StarWar sw = new StarWar();

            sw.PersonName = per.name;
            sw.PersonHome = per.homeworld;
            sw.PersonHeight = per.height;
            sw.PlanetName = pla.name;
            sw.PlanetPopulation = pla.population;
            sw.PlanetGravity = pla.gravity;



            return View(sw);
        }

        public IActionResult Person(int id)
        {
            Person p = swd.ConvertToPerson(id);
            return View(p);
        }
        public IActionResult Planet(int id)
        {
            Planet p = swd.ConvertToPlanet(id);
            return View(p);
        }


        public IActionResult Privacy()
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
