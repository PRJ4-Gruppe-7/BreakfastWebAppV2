using BreakfastWebAppV2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace BreakfastWebAppV2.Models
{
    public class ReceptionViewModel
    {
        public DateTime Date { get; set; }

        public List<Room> ListOfRooms { get; set; }




        public ReceptionViewModel (List<Room> rooms)
        {
            ListOfRooms = rooms;
        }
    }
}
