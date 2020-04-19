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

            return View(new ReceptionViewModel(context.Rooms.Include(r => r.Occupants).ToList()));
        }

        public ReceptionController (ApplicationDbContext dbcont)
        {
            context = dbcont;
        }
    }
}