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
    public class KitchenController : Controller
    {
        private ApplicationDbContext context;

        public IActionResult Index()
        {
            var rooms = context.Rooms.Include(r => r.Occupants).ToList();
            return View("Index", new KitchenViewModel(rooms, new DateTime(2020, 4, 19)));
        }

        [HttpPost]
        public ActionResult Submit()
        {
            var rooms = context.Rooms.Include(r => r.Occupants).ToList();
            return View("Index", new KitchenViewModel(rooms, DateTime.Parse(Request.Form["date"])));
        }

        public KitchenController(ApplicationDbContext dbcont)
        {
            context = dbcont;
        }
    }
}