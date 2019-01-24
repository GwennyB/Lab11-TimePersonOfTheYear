using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TimePersonOfTheYear.Models;

namespace TimePersonOfTheYear.Controllers
{
    public class HomeController : Controller
    {

        /// <summary>
        /// renders/sends Index view when default route is called
        /// </summary>
        /// <returns> rendered Index.cshtml </returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Redirects to Results action when form is submitted
        /// </summary>
        /// <param name="startYear"> user entered year to start search </param>
        /// <param name="endYear"> user entered year to end search </param>
        /// <returns> redirect to Results action with user inputs in tow </returns>
        [HttpPost]
        public IActionResult Index(int startYear, int endYear)
        {
            return RedirectToAction("Results", new { startYear, endYear });
        }

        /// <summary>
        /// gets search results and renders Results view with the results included
        /// </summary>
        /// <param name="startYear"> user entered year to start search </param>
        /// <param name="endYear"> user entered year to end search </param>
        /// <returns> rendered Results view </returns>
        [HttpGet]
        public IActionResult Results(int startYear, int endYear)
        {
            List<TimePerson> winners = TimePerson.GetPersons(startYear, endYear);
            return View(winners);
        }

    }
}
