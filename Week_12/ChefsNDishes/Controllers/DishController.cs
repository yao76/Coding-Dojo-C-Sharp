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
    public class DishController : Controller
    {
        private ChefContext dbDishContext;

        public DishController(ChefContext dContext)
        {
            dbDishContext = dContext;
        }
        [HttpGet("dishes")]
        public IActionResult Index()
        {
            List<Dish> AllDishes = dbDishContext.Dishes
            .Include(dish => dish.Creator)
            .OrderByDescending(d=>d.CreatedAt)
            .ToList();

            return View("Index", AllDishes);
        }

        [HttpGet("dishes/new")]
        public IActionResult NewDishForm()
        {
            ViewBag.AllChefs = dbDishContext.Chefs.ToList();
            return View();
        }

        [HttpPost("newdish")]
        public IActionResult AddDish(Dish formData)
        {
            if(ModelState.IsValid)
            {
                dbDishContext.Add(formData);
                dbDishContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("NewDishForm");
        }

    }
}
