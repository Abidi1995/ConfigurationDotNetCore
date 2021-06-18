using ConfigurationDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Controllers
{
    public class CompusController : Controller
    {
        private readonly CompanyContext _context;
        public CompusController(CompanyContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {

            var campuslist = _context.Campuses.ToList();
            return View(campuslist);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Campus campus)
        {
            if (ModelState.IsValid)
            {
                _context.Campuses.Add(campus);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(campus);



        }
        [HttpGet]
        public IActionResult EditCampus(int id)
        {
            var edit = _context.Campuses.Where(a => a.ID == id).FirstOrDefault();
            return View(edit);

        }
        [HttpPost]

        public IActionResult EditCampus(Campus campus)
        {
            var camInDb = _context.Campuses.Find(campus.ID);
            if (camInDb != null)
            {
                  camInDb.CampusName= campus.CampusName;
                camInDb.Address = campus.Address;
                camInDb.EmailId= campus.EmailId;
                camInDb.MailingName= campus.MailingName;
                camInDb.Mobile = campus.Mobile;
                camInDb.Password = campus.Password;
                camInDb.Phone = campus.Phone;
                camInDb.Web = campus.Web;
                _context.Campuses.Update(camInDb);

                _context.SaveChanges();
                return RedirectToAction("Index");



            }

            return View();
        }
        [HttpGet]
        public IActionResult DeleteCampus(int id)
        {
            var delCampus = _context.Campuses.Where(h => h.ID == id).FirstOrDefault();
            return View(delCampus);
        }
        [HttpPost]
        public IActionResult DeleteCampus(Campus campus)
        {
            var DbCam = _context.Campuses.Find(campus.ID);
            if (DbCam != null)
            {
                _context.Campuses.Remove(DbCam);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");

        }

    }
}
