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

        public IActionResult Set()
        {
            return View(new ReceptionViewModel(null, new DateTime(2020, 4, 19)));
        }

        [HttpPost]
        public ActionResult GetSubmit()
        {
            var rooms = context.Rooms.Include(r => r.Occupants).ToList();
            return View("Get", new ReceptionViewModel(rooms, DateTime.Parse(Request.Form["date"])));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(DateTime date, int RoomNumber, int AdultsWantBreakfast, int ChildrenWantBreakfast)
        {


            if (RoomNumber < 0)
            {
                return NotFound();
            }

            var room = await context.Rooms
                .Where(r => r.RoomNumber == RoomNumber)
                .Where(c => c.Occupants.Any(i => i.Date == date))
                .Select(c => new
                {
                    c,
                    Occupants = c.Occupants.Where(i => i.Date == date)
                })
                .FirstOrDefaultAsync();

            if (room == null)
            {
                var room1 = await context.Rooms
                .Where(r => r.RoomNumber == RoomNumber)
                .Include(r => r.Occupants)
                .FirstOrDefaultAsync();

                room1.Occupants.Add(new Occupants
                {
                    Adult = AdultsWantBreakfast,
                    Children = ChildrenWantBreakfast,
                    Date = date
                });

            } 
            else
            {
                room.c.Occupants.First().Adult = AdultsWantBreakfast;
                room.c.Occupants.First().Children = ChildrenWantBreakfast;

                
            }

            context.SaveChanges();


            return View("Set", new ReceptionViewModel(null,date));
        }





        //public ActionResult SetSubmit()
        //{
        //    string date_string = Request.Form["date"];
        //    DateTime date = DateTime.Parse(date_string);
        //    string roomnumber_string = Request.Form["RoomNumber"];
        //    int roomnumber = int.Parse(roomnumber_string);
        //    string adultsbreakfast_string = Request.Form["AdultsWantBreakfast"];
        //    int adultsbreakfast = int.Parse(adultsbreakfast_string);
        //    string childrenbreakfast_string = Request.Form["ChildrenWantBreakfast"];
        //    int childrenbreakfast = int.Parse(childrenbreakfast_string);

        //    //List<Room> RoomToEdit = context.Rooms
        //    //    .Where(r => r.RoomNumber == roomnumber)
        //    //    .Include(r => r.Occupants)
        //    //    .ToList();


        //     var RoomToEdit = context.Rooms
        //        .Where(r => r.RoomNumber == roomnumber)
        //        .Where(c => c.Occupants.Any(i => i.Date == date))
        //        .Select(c => new
        //        {
        //            c,
        //            Occupants = c.Occupants.Where(i => i.Date == date)
        //        })
        //        .FirstOrDefault();

        //    //.Where(r => r.Occupants.Any(o => o.Date == date))

        //    if (RoomToEdit != null)
        //    {
        //        //RoomToEdit.Occupants[0].;
        //    }

            

        //    return View("Set");
        //}

        public ReceptionController (ApplicationDbContext dbcont)
        {
            context = dbcont;
        }
    }
}