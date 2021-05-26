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
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductDetails productDetails)
        {
            if (ModelState.IsValid)
            {
                productDetails.MoreDescriptions = productDetails.MoreDescriptions;
                productDetails.Picture = productDetails.Picture;
                productDetails.Comments = productDetails.Comments;
                _context.ProductDetails.Add(productDetails);
                await _context.SaveChangesAsync();
            }
          
            return View(productDetails);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)//check for Product Code
            {
                return NotFound();
            }
            var productdetail = await _context.ProductDetails.FindAsync(id);//Find Product Code

            if (productdetail == null)
            {
                return NotFound();
            }
            return View(productdetail);
        }
        [HttpPost]
        public async Task<IActionResult>Edit(ProductDetails productDetails)
        {
            _context.Entry(productDetails).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult>Delete(int id)
        {
            var res = _context.ProductDetails.Where(x => x.Id == id).First();
           _context .ProductDetails.Remove(res);
            await _context.SaveChangesAsync();
            var list = _context.ProductDetails.ToListAsync();
            return View("Index", "list");


        }

    }
}
