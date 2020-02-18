using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dealership_Auto.Models;
using Dealership_Auto.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Dealership_Auto.Controllers
{
    public class TranzactieController : Controller
    {
        // Actiune care returneaza o lista cu toate tranzactiile
        public IActionResult ListareTranzactii()
        {
            var tranzactieRepository = new TranzactieRepository();
            var listaTranzactii = tranzactieRepository.GetTranzactii();

            return View(listaTranzactii);
        }

        // Actiune care returneaza o lista cu toate tranzactiile dupa anumite criterii
        public IActionResult ListareTranzactiii(string searchNumber, string searchModel)
        {
            var tranzactieRepository = new TranzactieRepository();
            var listaTranzactii = tranzactieRepository.GetTranzactiiFiltered(searchNumber, searchModel);

            return View(listaTranzactii);
        }

        // Actiune care returneaza o lista cu toate tranzactiile dupa anumite criterii
        public IActionResult ListareTranzactiiii()
        {
            var tranzactieRepository = new TranzactieRepository();
            var listaTranzactii = tranzactieRepository.GetTranzactiiComplex();

            return View(listaTranzactii);
        }

        // Actiune care returneaza detaliile unei tranzactii dupa ID
        public IActionResult DetailsTranzactie(int id)
        {
            var tranzactieRepository = new TranzactieRepository();
            var tranzactie = tranzactieRepository.GetTranzactie(id);

            return View(tranzactie);
        }

        // Actiuni care creaza o noua tranzactie
        [HttpGet]
        public IActionResult CreateTranzactie(int id)
        {
            var tranzactieRepository = new TranzactieRepository();
            var tranzactie = tranzactieRepository.GetForCreate(id);
            return View(tranzactie);
        }

        [HttpPost]
        public IActionResult CreateTranzactie(Tranzactie tranzactie)
        {
            var tranzactieRepository = new TranzactieRepository();
            tranzactieRepository.InsertTranzactie(tranzactie);
            return RedirectToAction("ListareTranzactii");
        }

        // Actiune care sterge o tranzactie dupa ID
        public IActionResult DeleteTranzactie(int id)
        {
            var tranzactieRepository = new TranzactieRepository();
            tranzactieRepository.RemoveTranzactie(id);

            return RedirectToAction("ListareTranzactii");
        }
    }
}