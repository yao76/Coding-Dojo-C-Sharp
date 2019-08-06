using Microsoft.AspNetCore.Mvc;
using System;
using ViewModelFun.Models;
using System.Collections.Generic;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string someString = "ABC";
            return View("Index", someString);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            var nums = new Numbers{
                numArray = new[]{1,2,3,4,5}
            };
            return View("Numbers", nums);
        }
        

        [HttpGet("user")]
        public IActionResult UserDetails()
        {
            User newuser = new User()
            {
                FirstName = "Eric",
                LastName = "Fang"
            };
            return View("UserDetails", newuser);
        }

        [HttpGet("users")]
        public IActionResult UserList()
        {
            List<User> userList = new List<User>();
            User newuser1 = new User()
            {
                FirstName = "Eric",
                LastName = "Fang"
            };
            User newuser2 = new User()
            {
                FirstName = "Joe",
                LastName = "Schmoe"
            };
            User newuser3 = new User()
            {
                FirstName = "Sponge",
                LastName = "Bob"
            };

            userList.Add(newuser1);
            userList.Add(newuser2);
            userList.Add(newuser3);

            return View("UsersList", userList);

        }
    }
}