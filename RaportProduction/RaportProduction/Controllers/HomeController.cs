using Microsoft.AspNetCore.Mvc;
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
           await Mediator.Send(new AddRaportCommand { Name = "Test" });

            return View();
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