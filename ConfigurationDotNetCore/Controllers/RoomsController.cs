using ConfigurationDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Controllers
{
    public class RoomsController : Controller
    {
        private readonly CompanyContext _context;
        public RoomsController(CompanyContext context)
        {
            _context = context;   
        }

        //Create Rooms
        public IActionResult Index()
        {
            ViewBag.hstlename = new SelectList(_context.Hostels, "id", "HostelName");
            var rooms = _context.Rooms.ToList();

            return View();
        }
        [HttpPost]//Adding Rooms of Hostel
        public string CreateRoom(Rooms rooms)
        {
            try
            {
                _context.Rooms.Add(rooms);
                _context.SaveChanges();
                return "Rooms Added Succesfully";

            }
            catch (Exception ex)
            {
                return ex.Message;
                
            }
        }
        public ActionResult EditRooms(int id)
        {
            ViewBag.hstlename = new SelectList(_context.Hostels, "Id", "HostelName");
            var GetRooms = _context.Rooms.Where(r => r.Id == id).FirstOrDefault();
            return View(GetRooms);
        }
        [HttpPost]//Method For Editing Rooms
        public string EditRooms(Rooms rooms)
        {
            var getRoomsToUpdate = _context.Rooms.Find(rooms.Id);
            if (getRoomsToUpdate != null)
            {
                getRoomsToUpdate.RoomNo = rooms.RoomNo;
                getRoomsToUpdate.Floor = rooms.Floor;
                getRoomsToUpdate.Capacity = rooms.Capacity;
                getRoomsToUpdate.HostelId = rooms.HostelId;
                
            }
            else
            {
                return "Failed to Edit rooms information";
            }
            try
            {
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            return "Sucesss";
        }
        [HttpGet]
        public ActionResult DeleteRoom(int id)
        {
            var del = _context.Rooms.Where(x => x.Id == id).FirstOrDefault();
            return View(del);

        }
        [HttpPost]
        public string DeleteRoom(Rooms rooms)
        {
            var roomfind = _context.Rooms.Find(rooms.Id);
            if (roomfind != null)
            {
                _context.Rooms.Remove(roomfind);
                _context.SaveChanges();
                
            }
            return "Not Deleted";
        }
             
  
    }
}
