using ConfigurationDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Controllers
{
    public class ProductController : Controller
    {
        private readonly CompanyContext _context;
        public ProductController(CompanyContext context)
        {
            _context = context;

        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }

        public ActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Create(Product product)
        {
            return View();
        }
    }
}
