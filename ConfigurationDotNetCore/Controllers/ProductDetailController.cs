using ConfigurationDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly CompanyContext _context;
        public ProductDetailController(CompanyContext context)
        {
            _context = context; 
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProductDetails.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductDetails productDetails)
        {
            return View();
        }
        public async Task<IActionResult> Edit(int? ProductCode)
        {
            return View();
        }

    }
}
