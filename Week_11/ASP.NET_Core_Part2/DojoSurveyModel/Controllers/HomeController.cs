using Microsoft.AspNetCore.Mvc;
using DojoSurveyModel.Models;
namespace DojoSurveyModel.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("/survey")]
        public IActionResult Result(Survey yoursurvey)
        {
            System.Console.WriteLine(new string('*', 40));
            System.Console.WriteLine("In post route!");
            System.Console.WriteLine(yoursurvey.Name);

            Survey newSurvey = new Survey()
            {
                Name=yoursurvey.Name,
                Location = yoursurvey.Location,
                Language = yoursurvey.Language,
                Comment = yoursurvey.Comment
                // Name=Request.Form["Name"],
                // Location = Request.Form["Location"],
                // Language = Request.Form["Language"],
                // Comment = Request.Form["Comment"]
            };
            return View("Result", newSurvey);
        }

        
    }
}