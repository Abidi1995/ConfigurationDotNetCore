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
        private readonly CompanyContext objemp;
        public CompanyController(CompanyContext context)
        {
            objemp = context;
        }

        public async Task<IActionResult> Index()
        { 
            return View(await objemp.Companies.ToListAsync());
            
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
        [HttpGet]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id)
        {
            var edit = objemp.Companies.Where(b => b.CompanyId == id).FirstOrDefault();
            return View(edit);
        }
        [HttpPost]
        public IActionResult Edit(Company company)
        {
            var CEdit = objemp.Companies.Find(company.CompanyId);
            if (CEdit != null)
            {

                CEdit.NoOfEmployees = company.NoOfEmployees;
                CEdit.RegisterationNo = company.RegisterationNo;
                CEdit.CompanyType = company.CompanyType;
                CEdit.CompanyNtNnO = company.CompanyNtNnO;
                CEdit.CompanyWebsite = company.CompanyWebsite;
                CEdit.Address = company.Address;
                objemp.Companies.Update(CEdit);
                objemp.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();


        }
        [HttpGet]

        public ActionResult Delete(int id)
        {
            var Delete_Company = objemp.Companies.Where(a => a.CompanyId == id).FirstOrDefault();
            return View(Delete_Company);
        }
        public ActionResult Delete(Company company)
        {
            var Delete_company = objemp.Companies.Find(company.CompanyId);
            if (Delete_company != null)
            {
                objemp.Companies.Remove(Delete_company);
                objemp.SaveChanges();
            }
            return RedirectToAction("Index");


        }

    }
}


