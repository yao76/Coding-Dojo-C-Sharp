using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;
namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("NewUser");
        }

        [HttpPost("register")]
        public IActionResult Register(User formData)
        {
            System.Console.WriteLine(new string('*', 80));
            if(ModelState.IsValid)
            {
                System.Console.WriteLine(new string('*', 80));
                System.Console.WriteLine("valid");
                return RedirectToAction("Result");
            } else {
                System.Console.WriteLine(new string('*', 80));
                System.Console.WriteLine("invalid");
                return View("NewUser");
            }

        }

        [HttpGet("registered")]
        public IActionResult Result()
        {
            System.Console.WriteLine(new string('*', 80));
            System.Console.WriteLine("Successfully registered");
            return View("Result");
        }
    }
}