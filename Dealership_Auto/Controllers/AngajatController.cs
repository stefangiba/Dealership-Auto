using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dealership_Auto.Models;
using Dealership_Auto.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Dealership_Auto.Controllers
{
    public class AngajatController : Controller
    {

        // Actiuni ce controleaza crearea de angajati
        [HttpGet]
        public IActionResult CreateAngajat()
        {
            return View(new Angajat());
        }

        [HttpPost]
        public IActionResult CreateAngajat(Angajat angajat)
        {
            var angajatRepository = new AngajatRepository();
            angajatRepository.InsertAngajat(angajat);
            return RedirectToAction("ListareAngajati");
        }

        // Actiuni ce controleaza crearea unei liste de angajati cu sau fara parametrii
        public IActionResult ListareAngajati()
        {
            var angajatRepository = new AngajatRepository();
            IList<Angajat> listaAngajati = angajatRepository.GetAngajati();

            return View(listaAngajati);
        }
        
        public IActionResult ListareAngajatii(string searchNumber, string searchNume)
        {
            var angajatRepository = new AngajatRepository();
            IList<Angajat> listaAngajati = angajatRepository.GetAngajatiFiltered(searchNumber, searchNume);

            return View(listaAngajati);
        }

        // Actiune ce controleaza stergerea din baza de date a unui angajat dupa ID-ul acestuia
        public IActionResult DeleteAngajat(int id)
        {
            var angajatRepository = new AngajatRepository();
            angajatRepository.DeleteAngajat(id);

            return RedirectToAction("ListareAngajati");
        }

        // Actiuni ce controleaza editarea unui angajat in baza de date dupa ID-ul acesteia
        [HttpGet]
        public IActionResult EditAngajat(int id)
        {
            var angajatRepository = new AngajatRepository();
            var angajat = angajatRepository.GetAngajat(id);
            return View(angajat);
        }
        [HttpPost]
        public IActionResult EditAngajat(Angajat angajat)
        {
            var angajatRepository = new AngajatRepository();
            angajatRepository.EditAngajat(angajat);
            return RedirectToAction("ListareAngajati");
        }

        // Actiune ce controleaza afisarea detaliilor unui angajat
        public IActionResult DetailsAngajat(int id)
        {
            var angajatRepository = new AngajatRepository();
            var angajat = angajatRepository.GetAngajat(id);
            return View(angajat);
        }
    }
}