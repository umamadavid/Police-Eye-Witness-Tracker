using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Police_Eye_Witness_Tracker.Models;

namespace Police_Eye_Witness_Tracker.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult AboutUs()
        {
            return View();
        }
    }
}