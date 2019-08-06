using Microsoft.AspNetCore.Mvc;
using System;
namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("Result")]
        public IActionResult ProcessSurvey(string name, string locations, string languages, string comment)
        {
            ViewBag.Name = name;
            ViewBag.Location = locations;
            ViewBag.Language = languages;
            ViewBag.Comment = comment;
            return View("Result");
        }
    }
}