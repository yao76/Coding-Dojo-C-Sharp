using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private DishesContext dbContext;
        public HomeController(DishesContext context)
        {
            dbContext = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {   // All dishes
            List<dishes> AllDishes = dbContext.Dishes.ToList();

            // All dishes ordered by newest first
            IEnumerable<dishes> allDishesOrdered = AllDishes.OrderByDescending(dish => dish.CreatedAt);
            // ViewBag.allDishesOrdered = AllDishes;

            return View("Index", allDishesOrdered);
        }
        [HttpGet("addDish")]
        public IActionResult New()
        {
            return View("NewDish");
        }

        [HttpPost("processDish")]
        public IActionResult AddDish(dishes formData)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(formData);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("NewDish");
        }

        [HttpGet("{CakeId}")]
        public IActionResult DishInfo(int CakeId)
        {
            dishes dish = dbContext.Dishes.FirstOrDefault(d=>d.CakeId == CakeId);
            // ViewBag.oneDish = dish;
            return View("OneDish",dish);
        }

        [HttpGet("delete/{CakeId}")]
        public IActionResult DeleteDish(int CakeId)
        {
            dishes dishToDelete = dbContext.Dishes.SingleOrDefault(d => d.CakeId == CakeId);
            dbContext.Dishes.Remove(dishToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("edit/{CakeId}")]
        public IActionResult ShowEditDish(int CakeId)
        {
            dishes dishToEdit = dbContext.Dishes.FirstOrDefault(d=>d.CakeId == CakeId);
            // ViewBag.dish = dishToEdit;
            return View("EditDish", dishToEdit);
        }

        [HttpPost("edit/{CakeId}")]
        public IActionResult EditDish(dishes formData, int CakeId)
        {
            dishes dishToEdit = dbContext.Dishes.FirstOrDefault(d=>d.CakeId == CakeId);
            // ViewBag.dish = dishToEdit;
            if(ModelState.IsValid)
            {
                dishToEdit.Name = formData.Name;
                dishToEdit.Chef = formData.Chef;
                dishToEdit.Calories = formData.Calories;
                dishToEdit.Description = formData.Description;
                dishToEdit.Tastiness = formData.Tastiness;
                dishToEdit.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("EditDish");
        }
    }
}
