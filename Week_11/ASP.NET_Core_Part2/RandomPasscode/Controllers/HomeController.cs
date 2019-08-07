using System;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            Random rand = new Random();
            
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string resultStr = "";
            for (int i = 0; i < 14; i++)
            {
                resultStr = resultStr + (chars[rand.Next(0, chars.Length)]);
            }
            ViewBag.Passcode = resultStr;

            int? Count = HttpContext.Session.GetInt32("Count");
            if(Count == null)
            {
                Count = 1;
            } else {
                Count++;
            }

            ViewBag.Count = Count;

            HttpContext.Session.SetInt32("Count", (int)Count);

            return View("Index");
        }

        [HttpGet("reset")]
        public IActionResult Clear() //function name doesn't have to match href
        {
            Console.WriteLine(new string('*', 10));
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

    }
}
