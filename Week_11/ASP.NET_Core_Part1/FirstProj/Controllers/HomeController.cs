using Microsoft.AspNetCore.Mvc;
namespace FirstProj
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public string Index()
        {
            return "Hello from controller";
        }
        [Route("hello")]
        [HttpGet]
        public string Hello()
        {
            return "Hi Again!";
        }

        [HttpGet("users/{username}")]
        public string HelloUser(string username)
        {
            return $"Hello {username}";
        }
    }
}