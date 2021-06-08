using ConfigurationDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Controllers
{
   
    public class VisitorsController : Controller
    {
        private readonly CompanyContext _context;
        public VisitorsController(CompanyContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            ViewBag.hostelname = new SelectList(_context.Hostels,"Id","HostelName");
            var visitor = _context.Visitors.ToList();    
            return View(visitor);
        }
        public string Create(Visitors visitors)
        {
            if(int.TryParse(Request.Form["regno"],out int regno))//Try to convert string into number
            {
                return "Invalid Registration No";


            }
            return "s";
        }
    }
}
