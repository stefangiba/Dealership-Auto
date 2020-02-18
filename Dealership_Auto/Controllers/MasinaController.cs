using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dealership_Auto.Models;
using Dealership_Auto.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Dealership_Auto.Controllers
{
    public class MasinaController : Controller
    {
        // actiune care listeaza toate masinile sau poate realiza o cautare dupa model
        public IActionResult ListareMasini(string search, string searchBy)
        {
            var masinaRepository = new MasinaRepository();
            IList<Masina> listaMasini;
            if (!String.IsNullOrEmpty(search))
            {
                listaMasini = masinaRepository.GetMasini(searchBy, search);
            }
            else
            {
                listaMasini = masinaRepository.GetMasini(searchBy, "");
            }
            return View(listaMasini);
        }

        // Actiuni care gestioneaza crearea unei noi masini in baza de date
        [HttpGet]
        public IActionResult CreateMasina()
        {
            return View(new Masina());
        }

        [HttpPost]
        public IActionResult CreateMasina(Masina masina)
        {
            var masiniRepository = new MasinaRepository();
            masiniRepository.InsertMasina(masina);
            return RedirectToAction("ListareMasini");
        }

        //Actiune care gestioneaza stergerea unei masini dupa ID
        public IActionResult DeleteMasina(int id)
        {
            var masiniRepository = new MasinaRepository();
            masiniRepository.DeleteMasina(id);
            return RedirectToAction("ListareMasini");
        }

        // Actiuni care gestioneaza editarea unei masini dupa ID
        [HttpGet]
        public IActionResult EditMasina(int id)
        {
            var masinaRepository = new MasinaRepository();
            var masina = masinaRepository.GetMasina(id);
            return View(masina);
        }
        [HttpPost]
        public IActionResult EditMasina(Masina masina)
        {
            var masinaRepository = new MasinaRepository();
            masinaRepository.EditMasina(masina);
            return RedirectToAction("ListareMasini");
        }

        // Actiune care returneaza o pagina cu detaliile unei masini dupa ID
        public IActionResult DetailsMasina(int id)
        {
            var masinaRepository = new MasinaRepository();
            var masina = masinaRepository.GetMasina(id);
            return View(masina);
        }

        //
        public IActionResult RedirectToList()
        {
            return RedirectToAction("ListareMasini");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}