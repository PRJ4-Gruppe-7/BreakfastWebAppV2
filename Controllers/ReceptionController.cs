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
            var rooms = context.Rooms.Include(r => r.Occupants).ToList();
            return View(new ReceptionViewModel(rooms, new DateTime(2020, 4, 19)));
        }

        [HttpPost]
        public ActionResult Submit()
        {
            var rooms = context.Rooms.Include(r => r.Occupants).ToList();
            return View("Index", new ReceptionViewModel(rooms, DateTime.Parse(Request.Form["date"])));
        }

        public ReceptionController (ApplicationDbContext dbcont)
        {
            context = dbcont;
        }
    }
}