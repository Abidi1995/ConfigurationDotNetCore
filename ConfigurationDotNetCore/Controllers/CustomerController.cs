﻿using ConfigurationDotNetCore.Models;
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
        private readonly EmployeeContext _context;
        public CustomerController(EmployeeContext context)
        {
            _context = context;

        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customers.ToListAsync());
        }
    }
}
