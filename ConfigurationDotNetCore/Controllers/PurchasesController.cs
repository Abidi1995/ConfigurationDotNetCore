using ConfigurationDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Controllers
{
    public class PurchasesController : Controller
    {
        private readonly CompanyContext _context;
        public PurchasesController(CompanyContext context)
        {
            _context = context;   
        }

        public IActionResult Index()
        {
            return View();
        }
        public string CreatePurchases(Purchases purchases)
        {
            try
            {
                _context.Purchases.Add(purchases);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            return "Purchases Addeed";
        }
        public ActionResult EditPurchases(int id)
        {
            var editp = _context.Purchases.Where(p => p.PurchasesID == id).FirstOrDefault();
            return View(editp);

        }
        public string EditPurchases(Purchases purchases)
        {
            var find = _context.Purchases.Find(purchases.PurchasesID);
            if (find != null)
            {
                try
                {
                    find.PurchasesID = purchases.PurchasesID;
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {

                    return ex.Message;
                }
             
            }
            return "Purchases Edited";
            

        }
        public ActionResult DeletePurchase(int id)
        {
            var del = _context.Purchases.Where(u => u.PurchasesID == id).FirstOrDefault();
            return View(del);
        }
        [HttpPost]
        public string DeletePurchase(Purchases purchases)
        {
            var del = _context.Purchases.Find(purchases.PurchasesID);
            if (del != null)
            {
                _context.Purchases.Remove(del);
                _context.SaveChanges();
            }
            else
            {
                return "Not Deleted";
            }
            return "Success";
        }

    }
}
