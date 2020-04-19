using BreakfastWebAppV2.Data;
using System;
using System.Collections.Generic;

namespace BreakfastWebAppV2.Models
{
    public class ReceptionViewModel
    {
        public DateTime TodoStartDate { get; set; }

        public List<Room> ListOfRooms { get; set; }

        public ReceptionViewModel (List<Room> rooms)
        {
            ListOfRooms = rooms;
        }
    }
}
