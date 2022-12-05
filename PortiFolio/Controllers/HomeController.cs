﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portifolio.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Portifolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Apis()
        {
            return View();
        }
        public IActionResult Contato()
        {
            return View();
        }
        public IActionResult Curriculo()
        {
            return View();
        }
        public IActionResult Portfolio()
        {
            return View();
        }
        public IActionResult TrabalhoInforSystem()
        {
            return View();
        }
        public IActionResult TrabalhoLeroy()
        {
            return View();
        }
        public IActionResult TrabalhoPorto()
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