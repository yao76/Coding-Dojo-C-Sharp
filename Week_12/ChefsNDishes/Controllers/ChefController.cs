using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers
{
    public class ChefController : Controller
    {
        private ChefContext dbChefContext;

        public ChefController(ChefContext chContext)
        {
            dbChefContext = chContext;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            List<Chef> listofchefs = dbChefContext.Chefs
            .Include(dishes=>dishes.CookedDishes)
            .OrderByDescending(chef=>chef.CreatedAt)
            .ToList();

            return View("Index", listofchefs);
        }

        [HttpGet("new")]
        public IActionResult NewChefForm()
        {
            return View("New");
        }

        [HttpPost("newchef")]
        public IActionResult NewChef(Chef formData)
        {
            if(ModelState.IsValid)
            {
                dbChefContext.Add(formData);
                dbChefContext.SaveChanges();
                return RedirectToAction("Index","Chef");
            }
            return View("New");
        }

    }
}
