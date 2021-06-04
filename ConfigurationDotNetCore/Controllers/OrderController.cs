using ConfigurationDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Controllers
{
    public class OrderController : Controller
    {
        private readonly CompanyContext _context;

        public OrderController(CompanyContext context)
        {
            _context = context;
        }
        public async Task<IActionResult>Index()
        {

            return View(await _context.Orders.ToListAsync());
        }
        public ActionResult Create()
        {
            return View();
        }
       [HttpPost]//Create Order post method
        public string Create(Orders orders)
        {
            try
            {
                _context.Orders.Add(orders);
                _context.SaveChanges();
                return "success";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        //Edit: Order Method
        public ActionResult EditOrder(int id)
        {
            var edit = _context.Orders.Where(h => h.Id == id).FirstOrDefault();
            return View(edit);
        }
        public string EditOrder(Orders orders)
        {
            var find = _context.Orders.Find(orders.Id);
            if (find != null)
            {
                find.Customers = orders.Customers;
                find.Employees = orders.Employees;
                find.OrderDate = orders.OrderDate;
                _context.SaveChanges();
            }
            else
            {
                return "not added";
            }
            return "Edited ";
        }
        public ActionResult DeleteOrder(int id)
        {
            var del = _context.Orders.Where(f => f.Id == id).FirstOrDefault();
            return View(del);
        }
        public string DeleteOrder(Orders orders)
        {
            var Del = _context.Orders.Find(orders.Id);
            if (Del != null)
            {
                _context.Orders.Remove(Del);
                _context.SaveChanges();
            }
            else
            {
                return "not deleted";
            }
            return "deleted";
        }
        
    }
}
