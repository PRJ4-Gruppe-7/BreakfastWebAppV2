using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using BreakfastWebAppV2.Data;
using BreakfastWebAppV2.Models;

namespace BreakfastWebAppV2.Controllers
{
    public class RestaurantController : Controller
    {
        public IActionResult Index(RestaurantViewModel model)
        {
            return View(model);
        }
    }
}