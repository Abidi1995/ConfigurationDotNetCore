using ConfigurationDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CompanyContext _context;
        public CategoryController(CompanyContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Lists()
        {
            return View(await _context.Categories.ToListAsync());
        }
        public IActionResult Index()
        {

            var listCategries = _context.Categories.ToList();
            return View();
        }
        public string CreateCategory(Categories categories)

        {
            try
            {
                _context.Categories.Add(categories);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                return ex.Message;
                
            }
            return ""; 
        }
        public ActionResult EditCategory(int id)
        {
            var cat = _context.Categories.Where(b => b.CategoryID == id).FirstOrDefault();
            return View(cat);
        }
    }
}
