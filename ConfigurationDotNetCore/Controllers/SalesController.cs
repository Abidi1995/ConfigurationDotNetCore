using ConfigurationDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Controllers
{
    public class SalesController : Controller
    {
        private readonly CompanyContext _context;
        public SalesController(CompanyContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string Create(Sales sales)
        {
            try
            {
                _context.Sales.Add(sales);
                _context.SaveChanges();
                return "Success";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public ActionResult EditSales(int id)
        {
            var sedit = _context.Sales.Where(i => i.SalesID == id).FirstOrDefault();
            return View(sedit);
        }
        [HttpPost]
        public string EditSales(Sales sales)
        {
            var find = _context.Sales.Find(sales.SalesID);
            if (find != null)
            {
                find.SalesID = sales.SalesID;
                _context.SaveChanges();

                
            }
            else
            {
                return "False";
            }
            return "Edit Sales";
        }
        public ActionResult DeleteSales(int id)
        {
            var dsale = _context.Sales.Where(d => d.SalesID == id).FirstOrDefault();
            return View(dsale);

        }
        [HttpPost]
        public ActionResult DeleteSales(Sales sales)
        {
            var desale = _context.Sales.Find(sales.SalesID);
            _context.Sales.Remove(desale);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
