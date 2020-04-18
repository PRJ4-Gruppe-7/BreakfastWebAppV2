using BreakfastWebAppV2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BreakfastWebAppV2.Models
{
    public class Room
    {
        [Key]
        public int RoomNumber { get; set; }
        public List<Occupants> Occupants { get; set; }
    }
}
