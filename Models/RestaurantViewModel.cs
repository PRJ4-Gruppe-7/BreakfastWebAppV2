using BreakfastWebAppV2.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreakfastWebAppV2.Models
{
    public class RestaurantViewModel
    {
        public int roomNumber { get; set; }
        public int childrenCount { get; set; }
        public int adultsCount { get; set; }

        public void Submit(ApplicationDbContext context)
        {
            var room = context.Rooms
                .Where(r => r.RoomNumber == roomNumber)
                .Where(c => c.Occupants.Any(i => i.Date == DateTime.Today))
                .Select(c => new
                {
                    c,
                    Occupants = c.Occupants.Where(i => i.Date == DateTime.Today)
                })
                .FirstOrDefault();

            int AdultsInRoom = room.c.Occupants.First().Adult;
            int ChildrenInRoom = room.c.Occupants.First().Children;

            int TotalAdultsCount = room.c.Occupants.First().CheckedInAdult + adultsCount;
            int TotalChildrenCount= room.c.Occupants.First().CheckedInChildren + childrenCount;

            if (room != null)
            {
                if (TotalAdultsCount <= AdultsInRoom)
                    room.c.Occupants.First().CheckedInAdult = TotalAdultsCount;
                if (TotalChildrenCount <= ChildrenInRoom)
                    room.c.Occupants.First().CheckedInChildren = TotalChildrenCount;
            }

            context.SaveChanges();
        }
    }
}
