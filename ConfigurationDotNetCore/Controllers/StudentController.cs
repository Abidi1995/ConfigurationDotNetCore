using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConfigurationDotNetCore.Models;

namespace ConfigurationDotNetCore.Controllers
{
    public class StudentController : Controller
    {
        private readonly CompanyContext _db;
        public StudentController(CompanyContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var list = _db.Students.ToList();
            return View(list);
        }
        [HttpGet]
        public ActionResult CreateStudent()
        {

            return View();
        }
        public ActionResult CreateStudent(Student student)
        {
            return View();
        }
    }
}
