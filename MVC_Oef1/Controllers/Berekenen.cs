using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Oef1.Controllers
{
    public class Berekenen : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Show()
        {
            ViewBag.Hello = "Hello MVC";
            ViewBag.Year = 2020;
            ViewBag.Aantal = 10;
            ViewData["Datum"] = DateTime.Now.AddDays(-1).ToString("dd/mm/yyyy");
            ViewData["List"] = new List<int>() {1,2,3,4,5,6,7,8,9,10 };
            return View();
        }
    }
}
