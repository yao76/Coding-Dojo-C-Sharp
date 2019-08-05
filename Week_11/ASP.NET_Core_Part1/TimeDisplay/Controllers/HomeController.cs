using Microsoft.AspNetCore.Mvc;
using System;
namespace TimeDisplay.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet("")]
        public ViewResult Index()
        {
            ViewBag.Title = "The current date and time";
            DateTime CurrentTime = DateTime.Now;
            ViewBag.Time = CurrentTime;
            System.Console.WriteLine("In INdex");
            return View();
        }
    }
}