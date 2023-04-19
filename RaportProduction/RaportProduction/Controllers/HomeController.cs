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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}