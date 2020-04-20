using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreakfastWebAppV2.Models
{
    public class KitchenViewModel
    {
        public DateTime DatePicked { get; set; }
        public List<Room> ListOfRooms { get; set; }

        public KitchenViewModel(List<Room> rooms, DateTime time)
        {
            DatePicked = time;
            ListOfRooms = rooms;
        }
    }
}
