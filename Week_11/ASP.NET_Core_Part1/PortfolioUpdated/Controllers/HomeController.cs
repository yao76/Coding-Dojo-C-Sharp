using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace PortfolioUpdated.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View("Projects");
        }

        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View("Contact");
        }
    }
}