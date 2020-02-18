using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dealership_Auto.Models;
using Dealership_Auto.Repository;

namespace Dealership_Auto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Actiuni ce se ocupa de login
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string Email, string Parola)
        {
            var angajatRepository = new AngajatRepository();
            var ok = angajatRepository.VerifyLoginInfo(Email, Parola);
            if (ok == true)
            {
                return RedirectToAction("ListareMasini", "Masina");
            }
            else return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
