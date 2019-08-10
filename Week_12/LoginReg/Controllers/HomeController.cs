using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginReg.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


namespace LoginReg.Controllers
{
    public class HomeController : Controller
    {
        private UserContext dbContext;

        public HomeController(UserContext context)
        {
            dbContext = context;
        }

        // Rendering Registration form
        [HttpGet("")]
        public IActionResult Register()
        {
            return View();
        }

        // Handling the registration, saving it to db if valid, send back to registration page if invalid
        [HttpPost("processregister")]
        public IActionResult ProccessRegister(User formData)
        {
            Console.WriteLine(new string('-', 80));
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u=>u.Email == formData.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Register");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                formData.Password = Hasher.HashPassword(formData, formData.Password);
                dbContext.Add(formData);
                dbContext.SaveChanges();
                User registeredUser = dbContext.Users.FirstOrDefault(u=>u.Email == formData.Email);
                HttpContext.Session.SetInt32("UserId", (int)registeredUser.UserId);
                return RedirectToAction("Success");
            }
            return View("Register");
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
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
                    ModelState.AddModelError("Email","Invalid Email");
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
                System.Console.WriteLine(HttpContext.Session.GetInt32("UserId"));

                return RedirectToAction("Success");
            }
            return View("Login");
        }

        // Render page for successful login or registration
        [HttpGet("/success")]
        public IActionResult Success()
        {

            // int? User_id = HttpContext.Session.GetInt32("UserId");
            // Console.WriteLine(new string('*', 80));
            // System.Console.WriteLine(HttpContext.Session.GetInt32("UserId"));
            // // HttpContext.Session.GetInt32("UserId")
            // if(User_id == 0)
            // {
            //     return RedirectToAction("Register");
            // } else {
            //     return View();
            // }

            return View();
            
        }

        [HttpGet("/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Register");
        }

    }
}
