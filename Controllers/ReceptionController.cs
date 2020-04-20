using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreakfastWebAppV2.Data;
using BreakfastWebAppV2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BreakfastWebAppV2.Controllers
{
    public class ReceptionController : Controller
    {
        private ApplicationDbContext context;

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Get()
        {
            var rooms = context.Rooms.Include(r => r.Occupants).ToList();
            return View(new ReceptionViewModel(rooms, new DateTime(2020, 4, 19)));
        }

        [HttpPost]
        public ActionResult GetSubmit()
        {
            var rooms = context.Rooms.Include(r => r.Occupants).ToList();
            return View("Get", new ReceptionViewModel(rooms, DateTime.Parse(Request.Form["date"])));
        }

        [HttpPost]
        public ActionResult SetSubmit()
        {
            string date = Request.Form["date"];
            string roomnumber = Request.Form["RoomNumber"];
            string adultsbreakfast = Request.Form["AdultsWantBreakfast"];
            string childrenbreakfast = Request.Form["ChildrenWantBreakfast"];

            //context.Add(new Occupants() { s})

            return View("Get");
        }

        public ReceptionController (ApplicationDbContext dbcont)
        {
            context = dbcont;
        }
    }
}