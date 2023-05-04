using Microsoft.AspNetCore.Mvc;
using RaportProduction.Application.Contacts.Commands.SendContactEmail;
using RaportProduction.Application.Raports.Commands.AddRaport;
using RaportProduction.Application.Raports.Queries.GetRaportById;
using RaportProduction.Models;
using RaportProduction.UI.Controllers;
using System.Diagnostics;

namespace RaportProduction.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View(new SendContactEmailCommand());
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Contact(SendContactEmailCommand command)
        {
            await Mediator.Send(command);

            return RedirectToAction("Contact");
        }
    }
}