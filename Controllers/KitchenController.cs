using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreakfastWebAppV2.Models;
using Microsoft.AspNetCore.Mvc;

namespace BreakfastWebAppV2.Controllers
{
    public class KitchenController : Controller
    {
        public IActionResult Index(KitchenViewModel model)
        {
            return View(model);
        }
    }
}