using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TimePersonOfTheYear.Models;

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
            return RedirectToAction("Results", new { startYear, endYear });
        }

        public IActionResult Results(int startYear, int endYear)
        {
            List<TimePerson> winners = TimePerson.GetPersons(startYear, endYear);
            return View(winners);
        }

    }
}
