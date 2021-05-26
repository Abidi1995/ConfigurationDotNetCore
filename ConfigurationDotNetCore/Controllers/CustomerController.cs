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
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                customer.CustomerName = customer.CustomerName;
                customer.Email = customer.Email;
                customer.Country = customer.Country;
                customer.ContactNo = customer.ContactNo;
                customer.Address = customer.Address;
                customer.MobileNo = customer.MobileNo;
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(customer);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
              
            }

            return View(customer);

        }
        public async Task<IActionResult>Edit(Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var delete = _context.Products.Where(c => c.Id == id).FirstOrDefault();
            _context.Products.Remove(delete);
            await _context.SaveChangesAsync();
            var list = _context.Products.ToListAsync();
            return View("Index", "list");
        }
    }
}
