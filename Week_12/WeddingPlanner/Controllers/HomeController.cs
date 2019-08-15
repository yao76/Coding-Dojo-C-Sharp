using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace WeddingPlanner.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        // Rendering Registration form
        [HttpGet("")]
        public IActionResult Register()
        {
            int? user_id = HttpContext.Session.GetInt32("UserId");
            if (user_id != null)
            {
                return RedirectToAction("Success");
            }
            return View();
        }

        // Handling the registration, saving it to db if valid, send back to registration page if invalid
        [HttpPost("processregister")]
        public IActionResult ProccessRegister(User formData)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u=>u.Email == formData.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                formData.Password = Hasher.HashPassword(formData, formData.Password);
                
                dbContext.Add(formData);
                dbContext.SaveChanges();
                System.Console.WriteLine(new string('@',80));
                System.Console.WriteLine(formData.UserId);

                HttpContext.Session.SetInt32("UserId", formData.UserId);
                return RedirectToAction("Success");
            }
            return View("Index");
        }
        [HttpGet("login")]
        public IActionResult Login()
        {
            int? user_id = HttpContext.Session.GetInt32("UserId");
            if (user_id != null)
            {
                return RedirectToAction("Success");
            }
            return View();
        }

        [HttpPost("proccesslogin")]
                public IActionResult ProcessLogin(LoginUser formData)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u=>u.Email == formData.Email);
                if(userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email!");
                    return View("Login");
                }
                var hasher = new PasswordHasher<LoginUser>();

                var result = hasher.VerifyHashedPassword(formData,userInDb.Password,formData.Password);
                if(result==0)
                {
                    ModelState.AddModelError("Password","Invalid Password");
                    return View("Login");
                }

                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("Success");
            }
            ModelState.AddModelError("Email", "Invalid email or password");
            return View("Login");
        }
        [HttpGet("/dashboard")]
        public IActionResult Success()
        {

            int? User_id = HttpContext.Session.GetInt32("UserId");
            User CurrUser = dbContext.Users.FirstOrDefault(u=>u.UserId == User_id);
            ViewBag.CurrUser = CurrUser;
            
            if (User_id == 0)
            {
                return RedirectToAction("Register");
            }
            else
            {
                List<Wedding> allweddings = dbContext.Weddings
                    .Include(w=>w.Guests)
                    .Include(w=>w.User)
                    .OrderByDescending(w=>w.CreatedAt)
                    .ToList();
                System.Console.WriteLine(new string('+',80));
                System.Console.WriteLine(User_id);
                return View("Dashboard", allweddings);
            }
        }

        [HttpGet("/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Register");
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            User creator = dbContext.Users.FirstOrDefault(u=>u.UserId == HttpContext.Session.GetInt32("UserId"));
            ViewBag.UserId = creator.UserId;
            return View();
        }

        [HttpPost("new")]
        public IActionResult NewWedding(Wedding formData)
        {
            if (ModelState.IsValid)
            {
                // WeddingGuest newguest = new WeddingGuest();
                // newguest.WeddingId = formData.WeddingId;
                // newguest.UserId = formData.UserId;

                dbContext.Add(formData);
                dbContext.SaveChanges();
                
                System.Console.WriteLine(new string('-', 80));
                return RedirectToAction("ViewWedding", new{id = formData.WeddingId});
            }
            

            System.Console.WriteLine(new string('*', 80));
            return View("New");
        }

        [HttpGet("/wedding/{id}")]
        public IActionResult ViewWedding(int id)
        {
            Wedding OneWedding = dbContext.Weddings
            .Include(w => w.Guests)
            .ThenInclude(g=>g.AssociatedAttendee)
            .FirstOrDefault(w=>w.WeddingId == id);

                
            return View(OneWedding);
        }

        [HttpGet("rsvp/{id}")]
        public IActionResult RSVP(int id)
        {
            User CurrentUser = dbContext.Users
                .SingleOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));

            Wedding CurrWedding = dbContext.Weddings
                .Include(g=>g.Guests)
                .ThenInclude(g=>g.AssociatedAttendee)
                .SingleOrDefault(g=>g.WeddingId == id);


            WeddingGuest OneGuest = dbContext.WeddingGuests
                .Where(g=>g.WeddingId == id)
                .SingleOrDefault(g=>g.UserId == CurrentUser.UserId);

            if(OneGuest != null)
            {
                dbContext.WeddingGuests.Remove(OneGuest);
            }
            else 
            {
                WeddingGuest newguest = new WeddingGuest() {
                    UserId = CurrentUser.UserId,
                    WeddingId = CurrWedding.WeddingId
                };
                CurrWedding.Guests.Add(newguest);
            }
            dbContext.SaveChanges();
            return RedirectToAction("Success");
        }


        [HttpGet("dashboard/delete/{id}")]
        public IActionResult DeleteWedding(int id)
        {
            Wedding WeddingToRemove = dbContext.Weddings
                .SingleOrDefault(u=>u.WeddingId == id);
            
            if(WeddingToRemove != null)
            {
                dbContext.Weddings.Remove(WeddingToRemove);
                dbContext.SaveChanges();
            }

            return RedirectToAction("Success");
        }




    }
}
