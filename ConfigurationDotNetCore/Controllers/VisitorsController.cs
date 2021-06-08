using ConfigurationDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Controllers
{
   
    public class VisitorsController : Controller
    {
        private readonly CompanyContext _context;
        public VisitorsController(CompanyContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            ViewBag.hostelname = new SelectList(_context.Hostels,"Id","HostelName");
            var visitor = _context.Visitors.ToList();    
            return View(visitor);
        }
        public string Create(Visitors visitors)
        {
            if(int.TryParse(Request.Form["regno"],out int regno))//Try to convert string into number
            {
                return "Invalid Registration Number";

            }
            try
            {
                _context.Visitors.Add(visitors);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            return "";
            
        }
        public ActionResult Edit(int id)
        {
            ViewBag.HotelName = new SelectList(_context.Hostels, "id", "HostelName");
            var getData = _context.Visitors.Where(n => n.HostelId==id).FirstOrDefault();
            ViewBag.RegNo = _context.HostelAdmissions.Where(a => a.Id == getData.HostleAdmId).Select(s => s.Admission.StudentID == id).FirstOrDefault();
            return View(getData);

        }
        public string Edit(Visitors visitors)
        {
            var evisitToUpdate = _context.Visitors.Find(visitors.VisitorID);
            if (evisitToUpdate != null)
            {
                evisitToUpdate.Name = visitors.Name;
                evisitToUpdate.Relationship = visitors.Relationship;
                evisitToUpdate.TimeIn = visitors.TimeIn;
                evisitToUpdate.TimeOut = visitors.TimeIn;
                evisitToUpdate.Cnic = visitors.Cnic;

            }
            else
            {
                return "Failed";
            }
            try
            {
                _context.SaveChanges();
                return "succussfully visitors edited";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public ActionResult DeleteVisitor(int id)
        {
            var getdataVisitor = _context.Visitors.Where(b => b.HostelId==id).FirstOrDefault();
            return View(getdataVisitor);
        }
        public string DeleteVisitor(Visitors visitors)
        {
            var del = _context.Visitors.Find(visitors.VisitorID);
            if (del != null)
            {
                _context.Visitors.Remove(del);
                _context.SaveChanges();
            }
            return "false";
        }



    }
}
