using ConfigurationDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CompanyContext _context;
        public CustomerController(CompanyContext context)
        {
            _context = context;

        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customers.ToListAsync());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Create(Customer customer)
        {
            return View();
        }
        public async Task<IActionResult> Edit(int ? CustomerId)
        {
            return View();
        }
    }
}
