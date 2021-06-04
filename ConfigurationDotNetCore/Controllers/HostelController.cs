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
            return View();
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
            var hedit = _context.Hostels.Where(h => h.Id==id).FirstOrDefault();
            return View(hedit);

        }
        public string EditHostel(Hostel hostel)
        {
            var findh = _context.Hostels.Find(hostel.Id);
            if (findh != null)
            {
                hostel.HostelName = findh.HostelName;
                hostel.Location = findh.Location;
                hostel.TotalRooms = findh.TotalRooms;
                hostel.TotalStudents = findh.TotalStudents;
                hostel.CampusId = findh.CampusId;
                return "edit";
            }
            else
            {
                return "failed";
            }
            try
            {
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public A
    }
}