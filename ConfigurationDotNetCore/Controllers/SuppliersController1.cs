﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Controllers
{
    public class SuppliersController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
