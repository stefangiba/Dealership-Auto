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
    public class ClientController : Controller
    {
        [HttpGet]
        public IActionResult CreateClient()
        {
            return View(new Client());
        }

        [HttpPost]
        public IActionResult CreateClient(Client client)
        {
            var clientRepository = new ClientRepository();
            clientRepository.InsertClient(client);
            return RedirectToAction("ListareClienti");
        }

        public IActionResult ListareClienti()
        {
            var clientRepository = new ClientRepository();
            IList<Client> listaClienti = clientRepository.GetClienti();

            return View(listaClienti);
        }

        public IActionResult ListareClientii(string searchNumber, string searchProducator)
        {
            var clientRepository = new ClientRepository();
            IList<Client> listaClienti = clientRepository.GetClienti(searchNumber, searchProducator);

            return View(listaClienti);
        }

        public IActionResult DeleteClient(int id)
        {
            var clientRepository = new ClientRepository();
            clientRepository.DeleteClient(id);

            return RedirectToAction("ListareClienti");
        }

        [HttpGet]
        public IActionResult EditClient(int id)
        {
            var clientRepository = new ClientRepository();
            var client = clientRepository.GetClient(id);
            return View(client);
        }
        [HttpPost]
        public IActionResult EditClient(Client client)
        {
            var clientRepository = new ClientRepository();
            clientRepository.EditClient(client);
            return RedirectToAction("Listareclienti");
        }

        public IActionResult DetailsClient(int id)
        {
            var clientRepository = new ClientRepository();
            var client = clientRepository.GetClient(id);
            return View(client);
        }
    }
}