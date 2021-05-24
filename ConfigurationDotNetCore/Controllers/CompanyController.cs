using ConfigurationDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Controllers
{
    public class CompanyController : Controller
    {
        private readonly EmployeeContext objemp;
        public CompanyController(EmployeeContext context)
        {
            objemp = context;
        }

        public async Task<IActionResult> Index()
        {
            return View( await objemp.Companies.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyName", "RegisterationNo", "CompanyType", " Address", "NoOfEmployees", "CompanyNtNnO", "CompanyWebsite")] Company company)
        {
            if (ModelState.IsValid)
            {
                objemp.Companies.Add(company);
                await objemp.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(company);

        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var company = await objemp.Companies.FindAsync(id);
            if (id == null)
            {
                return NotFound();
            }
            return View(company);
        }
        public async Task<IActionResult> Edit(int id, [Bind("CompanyName", "RegisterationNo", "CompanyType", " Address", "NoOfEmployees", "CompanyNtNnO", "CompanyWebsite")] Company company)
        {
            if (id != company.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    objemp.Update(company);
                    await objemp.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyExists(company.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(company);

        }
       
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await objemp.Companies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (company == null)
            {
                return NotFound();
            }

            return View(company);

        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var company = await objemp.Companies.FindAsync(id);
             objemp.Remove(company);
            await objemp.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        private bool CompanyExists(int id)
        {
            return objemp.Companies.Any(e => e.Id == id);
        }

    }

}
