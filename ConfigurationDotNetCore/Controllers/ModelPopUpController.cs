using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Controllers
{
    public class ModelPopUpController : Controller
    {   // GET Method of Home Controller
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult ModlPopUp()
        {
            return View();
        }
    }
}
