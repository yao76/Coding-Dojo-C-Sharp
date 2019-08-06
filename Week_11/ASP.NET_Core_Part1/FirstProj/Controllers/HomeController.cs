using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace FirstProj.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            ViewBag.Example="Hello World";
            return View();
        }

        [HttpGet("projects")]
        public RedirectToActionResult Projects()
        {
            System.Console.WriteLine("In projects");
            return RedirectToAction("Index");
        }

        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my Contact!";
        }
    }
}