﻿using Microsoft.AspNetCore.Mvc;

namespace EDIPrivate.Controllers
{
    public sealed class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index() =>
            View();
    }
}