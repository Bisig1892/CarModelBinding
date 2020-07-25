using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarModelBinding.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarModelBinding.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Car c)
        {
            if (ModelState.IsValid)
            {
                ViewData["Message"] = $"{c.Make} {c.Model} will start production on {c.Year}";
                // Add to database here...
            }
            return View();
        }
    }
}
