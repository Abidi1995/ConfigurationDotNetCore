using ConfigurationDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Controllers
{
    public class HostelController : Controller
    {
        private readonly CompanyContext _context;
        public HostelController(CompanyContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var hostellist = _context.Hostels.ToList();
            return View(hostellist);
        }
        public string AddHostel(Hostel hostel)
        {
            try
            {
                _context.Hostels.Add(hostel);
                _context.SaveChanges();
                return "SUCCESS ADDED HOSTEL";


            }
            catch (Exception ex)
            {
                ModelState.Clear();
                return ex.Message;
            }
            
            
        }
        public ActionResult EditHostel(int id)
        {
            var hedit = _context.Hostels.Where(h => h.HostelId==id).FirstOrDefault();
            return View(hedit);

        }
        public ActionResult EditHostel(Hostel hostel)
        {
            var findh = _context.Hostels.Find(hostel.HostelId);
            if (findh != null)
            {
                findh.HostelName = hostel.HostelName;
                findh.Location = hostel.Location;
                findh.TotalRooms = hostel.TotalStudents;
                findh.TotalStudents = hostel.TotalStudents;

                return RedirectToAction("Index");



            }
            return View();

          
            
        }
        public ActionResult Delete(int id)
        {
            var del = _context.Hostels.Where(h => h.HostelId == id).FirstOrDefault();
            return View(del);
        }
        public string Delete(Hostel hostel)
        {
            string Message = string.Empty;
            try
            {
                hostel = _context.Hostels.Find(hostel.HostelId);
                _context.Hostels.Remove(hostel);
                _context.SaveChanges();
            }
            catch (Exception  ex)
            {

                return ex.Message;
            }
            return "Message";
        }
       
    }
}