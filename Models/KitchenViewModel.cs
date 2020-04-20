using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreakfastWebAppV2.Models
{
    public class KitchenViewModel
    {
        public int ChildrenNotCheckedIn { get; set; }
        public int AdultsNotCheckedIn { get; set; }
        public DateTime DatePicked { get; set; }

        public KitchenViewModel(DateTime time)
        {
            DatePicked = time;
        }
    }
}
