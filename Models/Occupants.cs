using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BreakfastWebAppV2.Models
{
    public class Occupants
    {
        public int RoomNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        public DateTime Date { get; set; }
        public int Adult { get; set; }
        public int Children { get; set; }
        public int CheckedInAdult { get; set; }
        public int CheckedInChildren { get; set; }
    }
}
