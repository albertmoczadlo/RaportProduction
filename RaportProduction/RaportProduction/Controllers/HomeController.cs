﻿using AspNetCore.ReCaptcha;
using Microsoft.AspNetCore.Mvc;
using RaportProduction.Application.Common.Exceptions;
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

        [ValidateReCaptcha]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Contact(SendContactEmailCommand command)
        {
            var result = await MediatorSendValidate(command);

            if (!result.IsValid)
            {
                ModelState.AddModelError("AntySpamResult","Fill in the ReCaptcha field (spam protection)");
                return View(command);
            }

            TempData["Success"] = "Message send";

            return RedirectToAction("Contact");
        }
    }
}