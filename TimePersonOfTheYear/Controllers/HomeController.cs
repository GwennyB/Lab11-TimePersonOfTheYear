using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimePersonOfTheYear.Controllers;

namespace TimePersonOfTheYear.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Index(int startYear, int endYear)
        {
            List<string> winners = new List<string> { "", "" };

            return RedirectToAction("Results", winners);
        }

        [HttpGet]
        public IActionResult Result(List<string> winners)
        {
            return View();
        }

        //// model binding example
        //public string Balloon(int numberOfBalloons)
        //{
        //    return $"You have {numberOfBalloons} balloons";
        //}
    }
}
