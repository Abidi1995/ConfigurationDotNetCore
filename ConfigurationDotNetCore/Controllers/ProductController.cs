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
        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid) {
                product.ProductName = product.ProductName;
                product.ProductType = product.ProductType;
                product.PurchasePrice = product.PurchasePrice;
                product.SalePrice = product.SalePrice;
                product.Stock = product.Stock;
                product.UnitPrice = product.UnitPrice;
                product.SupplierName = product.SupplierName;
                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(product);
            
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var find = await _context.Products.FindAsync(id);
            if (find == null)
            {
                return NotFound();
            }
            return View(find);
        }
        public async Task<IActionResult> Edit(Product product)

        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return View(product);


        }
    
        public async Task<IActionResult> Delete(Product product, int id)
        {
            var del = _context.Products.Where(p => p.Id == id).FirstOrDefault();
            _context.Products.Remove(del);
            await _context.SaveChangesAsync();
            var list = _context.Products.ToListAsync();
            return View("Index", "list");
        }

    }
}
