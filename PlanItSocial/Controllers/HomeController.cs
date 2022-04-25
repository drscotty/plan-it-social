﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlanItSocial.Data;
using PlanItSocial.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PlanItSocial.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDAL _idal;

        public HomeController(ILogger<HomeController> logger, IDAL idal)
        {
            _logger = logger;
            _idal = idal;
        }

        public IActionResult Index()
        {
            var myevent = _idal.GetEvent(1);
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
