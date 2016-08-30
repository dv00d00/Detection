﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wangkanai.Browser;
using Wangkanai.Browser.Abstractions;

namespace Sandbox.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBrowserService _browser;

        public HomeController(IBrowserService browser)
        {
            _browser = browser;
        }

        public IActionResult Index()
        {
            var browser = HttpContext.Request.Browser();
            var platform = HttpContext.Request.Platform();
            var device = HttpContext.Request.Device();
            var engine = HttpContext.Request.Engine();
            return View(_browser);
        }
    }
}
