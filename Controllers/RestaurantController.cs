using Microsoft.AspNetCore.Mvc;
using BreakfastWebAppV2.Data;
using System.Threading.Tasks;
using System;
using System.Linq;
using BreakfastWebAppV2.Models;

namespace BreakfastWebAppV2.Controllers
{
    public class RestaurantController : Controller
    {
        private ApplicationDbContext context;

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostSubmit(RestaurantViewModel model)
        {
            model.Submit(context);

            return View("Index");
        }

        public RestaurantController(ApplicationDbContext dbcont)
        {
            context = dbcont;
        }
    }
}