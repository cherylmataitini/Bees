using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bees.Models;

namespace BeesTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private List<Bee> _bees = new List<Bee>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            for (var i = 0; i < 10; i++)
            {
                _bees.Add(new Worker());
            }
            for (var i = 0; i < 10; i++)
            {
                _bees.Add(new Drone());
            }
            for (var i = 0; i < 10; i++)
            {
                _bees.Add(new Queen());
            }
        }

        public IActionResult Index()
        {

            return View(_bees);
        }

        public IActionResult Damage()
        {
            foreach (var bee in _bees)
            {
                Random r = new Random();
                int rInt = r.Next(0, 80);
                bee.Damage(rInt);
            }
            //return PartialView("_Bees", _bees);
            return View("Index", _bees);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
